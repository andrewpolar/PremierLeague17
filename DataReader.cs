using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace PremierLeague17
{
    class DataReader
    {
        private int Month(string mon)
        {
            if (mon.Contains("Jan")) return 1;
            if (mon.Contains("Feb")) return 2;
            if (mon.Contains("Mar")) return 3;
            if (mon.Contains("Apr")) return 4;
            if (mon.Contains("May")) return 5;
            if (mon.Contains("Jun")) return 6;
            if (mon.Contains("Jul")) return 7;
            if (mon.Contains("Aug")) return 8;
            if (mon.Contains("Sep")) return 9;
            if (mon.Contains("Oct")) return 10;
            if (mon.Contains("Nov")) return 11;
            if (mon.Contains("Dec")) return 12;
            return -1;
        }

        public List<Game> ProcessFile(string fileName)
        {
            DateTime currentDate = DateTime.MinValue;
            List<Game> games = new List<Game>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                    {
                        break;
                    }

                    if (line.Trim().Length < 1)
                    {
                        break;
                    }

                    string[] data = line.Split(" ");
                    if (!line.Contains(":"))
                    {
                        int year = -1;
                        Int32.TryParse(data[2], out year);
                        int month = Month(data[1]);
                        int day = -1;
                        Int32.TryParse(data[0], out day);
                        currentDate = new DateTime(year, month, day);
                    }
                    else if (data.Length >= 5)
                    {
                        string[] data2 = data[0].Split(":");
                        int hour = -1;
                        int min = -1;
                        Int32.TryParse(data2[0], out hour);
                        Int32.TryParse(data2[1], out min);
                        DateTime gameDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, hour, min, 0);

                        int scorePosition = -1;
                        for (int k = data.Length - 1; k > 0; --k)
                        {
                            if (data[k].Contains(":"))
                            {
                                scorePosition = k;
                                break;
                            }
                        }

                        if (-1 == scorePosition)
                        {
                            Console.WriteLine("Misformatted line: {0}", line);
                            Environment.Exit(0);
                        }

                        string score = data[scorePosition];
                        string[] data3 = score.Split(":");
                        int goalsHome = -1;
                        int goalsAway = -1;
                        Int32.TryParse(data3[0], out goalsHome);
                        Int32.TryParse(data3[1], out goalsAway);
                        string teams = "";
                        int cnt = 0;
                        foreach (string s in data)
                        {
                            ++cnt;
                            if (cnt > 1 && cnt <= scorePosition)
                            {
                                teams += s;
                                teams += " ";
                            }
                        }
                        string[] data4 = teams.Split("-");
                        string teamHome = data4[0];
                        string teamAway = data4[1];
 
                        int Bet1 = 0;
                        int BetX = 0;
                        int Bet2 = 0;
                        if (data.Length - 1 > scorePosition)
                        {
                            string bet1 = data[scorePosition + 1];
                            string betX = data[scorePosition + 2];
                            string bet2 = data[scorePosition + 3];

                            Int32.TryParse(bet1, out Bet1);
                            Int32.TryParse(betX, out BetX);
                            Int32.TryParse(bet2, out Bet2);
                        }

                        games.Add(new Game(teamHome.Trim(), teamAway.Trim(), gameDate, goalsHome, goalsAway, Bet1, BetX, Bet2));
                    }
                    else
                    {
                        Console.WriteLine("Misformatted line: {0}", line);
                        Environment.Exit(0);
                    }
                }
            }
            games.Sort();
            return games;
        }
    }
}
