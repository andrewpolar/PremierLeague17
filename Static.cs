using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PremierLeague17
{
    static class Static
    {
        public static Dictionary<string, int> _standings_2012_2013 = null;
        public static Dictionary<string, int> _standings_2013_2014 = null;
        public static Dictionary<string, int> _standings_2014_2015 = null;
        public static Dictionary<string, int> _standings_2015_2016 = null;
        public static Dictionary<string, int> _standings_2016_2017 = null;
        public static Dictionary<string, int> _standings_2017_2018 = null;
        public static Dictionary<string, int> _standings_2018_2019 = null;
        public static Dictionary<string, int> _standings_2019_2020 = null;

        private static double[,] _matrix_2012_2013 = new double[17, 17];
        private static double[,] _matrix_2013_2014 = new double[17, 17];
        private static double[,] _matrix_2014_2015 = new double[17, 17];
        private static double[,] _matrix_2015_2016 = new double[17, 17];
        public static double[,] _matrix_2016_2017 = new double[17, 17];
        public static double[,] _matrix_2017_2018 = new double[17, 17];
        public static double[,] _matrix_2018_2019 = new double[17, 17];
        public static double[,] _matrix_2019_2020 = new double[17, 17];

        public static void MakeAllStandings()
        {
            if (null == _standings_2012_2013)
            {
                _standings_2012_2013 = new Dictionary<string, int>();
                _standings_2012_2013.Add("Manchester Utd", 0);
                _standings_2012_2013.Add("Manchester City", 1);
                _standings_2012_2013.Add("Chelsea", 2);
                _standings_2012_2013.Add("Arsenal", 3);
                _standings_2012_2013.Add("Tottenham", 4);
                _standings_2012_2013.Add("Everton", 5);
                _standings_2012_2013.Add("Liverpool", 6);
                _standings_2012_2013.Add("West Brom", 7);
                _standings_2012_2013.Add("Swansea", 8);
                _standings_2012_2013.Add("West Ham", 9);
                _standings_2012_2013.Add("Norwich", 10);
                _standings_2012_2013.Add("Fulham", 11);
                _standings_2012_2013.Add("Stoke", 12);
                _standings_2012_2013.Add("Southampton", 13);
                _standings_2012_2013.Add("Aston Villa", 14);
                _standings_2012_2013.Add("Newcastle", 15);
                _standings_2012_2013.Add("Sunderland", 16);
                _standings_2012_2013.Add("Wigan", 17);
                _standings_2012_2013.Add("Reading", 18);
                _standings_2012_2013.Add("QPR", 19);
            }

            if (null == _standings_2013_2014)
            {
                _standings_2013_2014 = new Dictionary<string, int>();
                _standings_2013_2014.Add("Manchester City", 0);
                _standings_2013_2014.Add("Liverpool", 1);
                _standings_2013_2014.Add("Chelsea", 2);
                _standings_2013_2014.Add("Arsenal", 3);
                _standings_2013_2014.Add("Everton", 4);
                _standings_2013_2014.Add("Tottenham", 5);
                _standings_2013_2014.Add("Manchester Utd", 6);
                _standings_2013_2014.Add("Southampton", 7);
                _standings_2013_2014.Add("Stoke", 8);
                _standings_2013_2014.Add("Newcastle", 9);
                _standings_2013_2014.Add("Crystal Palace", 10);
                _standings_2013_2014.Add("Swansea", 11);
                _standings_2013_2014.Add("West Ham", 12);
                _standings_2013_2014.Add("Sunderland", 13);
                _standings_2013_2014.Add("Aston Villa", 14);
                _standings_2013_2014.Add("Hull", 15);
                _standings_2013_2014.Add("West Brom", 16);
                _standings_2013_2014.Add("Norwich", 17);
                _standings_2013_2014.Add("Fulham", 18);
                _standings_2013_2014.Add("Cardiff", 19);
            }

            if (null == _standings_2014_2015)
            {
                _standings_2014_2015 = new Dictionary<string, int>();
                _standings_2014_2015.Add("Chelsea", 0);
                _standings_2014_2015.Add("Manchester City", 1);
                _standings_2014_2015.Add("Arsenal", 2);
                _standings_2014_2015.Add("Manchester Utd", 3);
                _standings_2014_2015.Add("Tottenham", 4);
                _standings_2014_2015.Add("Liverpool", 5);
                _standings_2014_2015.Add("Southampton", 6);
                _standings_2014_2015.Add("Swansea", 7);
                _standings_2014_2015.Add("Stoke", 8);
                _standings_2014_2015.Add("Crystal Palace", 9);
                _standings_2014_2015.Add("Everton", 10);
                _standings_2014_2015.Add("West Ham", 11);
                _standings_2014_2015.Add("West Brom", 12);
                _standings_2014_2015.Add("Leicester", 13);
                _standings_2014_2015.Add("Newcastle", 14);
                _standings_2014_2015.Add("Sunderland", 15);
                _standings_2014_2015.Add("Aston Villa", 16);
                _standings_2014_2015.Add("Hull", 17);
                _standings_2014_2015.Add("Burnley", 18);
                _standings_2014_2015.Add("QPR", 19);
            }

            if (null == _standings_2015_2016)
            {
                _standings_2015_2016 = new Dictionary<string, int>();
                _standings_2015_2016.Add("Leicester", 0);
                _standings_2015_2016.Add("Arsenal", 1);
                _standings_2015_2016.Add("Tottenham", 2);
                _standings_2015_2016.Add("Manchester City", 3);
                _standings_2015_2016.Add("Manchester Utd", 4);
                _standings_2015_2016.Add("Southampton", 5);
                _standings_2015_2016.Add("West Ham", 6);
                _standings_2015_2016.Add("Liverpool", 7);
                _standings_2015_2016.Add("Stoke", 8);
                _standings_2015_2016.Add("Chelsea", 9);
                _standings_2015_2016.Add("Everton", 10);
                _standings_2015_2016.Add("Swansea", 11);
                _standings_2015_2016.Add("Watford", 12);
                _standings_2015_2016.Add("West Brom", 13);
                _standings_2015_2016.Add("Crystal Palace", 14);
                _standings_2015_2016.Add("Bournemouth", 15);
                _standings_2015_2016.Add("Sunderland", 16);
                _standings_2015_2016.Add("Newcastle", 17);
                _standings_2015_2016.Add("Norwich", 18);
                _standings_2015_2016.Add("Aston Villa", 19);
            }

            if (null == _standings_2016_2017)
            {
                _standings_2016_2017 = new Dictionary<string, int>();
                _standings_2016_2017.Add("Chelsea", 0);
                _standings_2016_2017.Add("Tottenham", 1);
                _standings_2016_2017.Add("Manchester City", 2);
                _standings_2016_2017.Add("Liverpool", 3);
                _standings_2016_2017.Add("Arsenal", 4);
                _standings_2016_2017.Add("Manchester Utd", 5);
                _standings_2016_2017.Add("Everton", 6);
                _standings_2016_2017.Add("Southampton", 7);
                _standings_2016_2017.Add("Bournemouth", 8);
                _standings_2016_2017.Add("West Brom", 9);
                _standings_2016_2017.Add("West Ham", 10);
                _standings_2016_2017.Add("Leicester", 11);
                _standings_2016_2017.Add("Stoke", 12);
                _standings_2016_2017.Add("Crystal Palace", 13);
                _standings_2016_2017.Add("Swansea", 14);
                _standings_2016_2017.Add("Burnley", 15);
                _standings_2016_2017.Add("Watford", 16);
                _standings_2016_2017.Add("Hull", 17);
                _standings_2016_2017.Add("Middlesbrough", 18);
                _standings_2016_2017.Add("Sunderland", 19);
            }

            if (null == _standings_2017_2018)
            {
                _standings_2017_2018 = new Dictionary<string, int>();
                _standings_2017_2018.Add("Manchester City", 0);
                _standings_2017_2018.Add("Manchester Utd", 1);
                _standings_2017_2018.Add("Tottenham", 2);
                _standings_2017_2018.Add("Liverpool", 3);
                _standings_2017_2018.Add("Chelsea", 4);
                _standings_2017_2018.Add("Arsenal", 5);
                _standings_2017_2018.Add("Burnley", 6);
                _standings_2017_2018.Add("Everton", 7);
                _standings_2017_2018.Add("Leicester", 8);
                _standings_2017_2018.Add("Newcastle", 9);
                _standings_2017_2018.Add("Crystal Palace", 10);
                _standings_2017_2018.Add("Bournemouth", 11);
                _standings_2017_2018.Add("West Ham", 12);
                _standings_2017_2018.Add("Watford", 13);
                _standings_2017_2018.Add("Brighton", 14);
                _standings_2017_2018.Add("Huddersfield", 15);
                _standings_2017_2018.Add("Southampton", 16);
                _standings_2017_2018.Add("Swansea", 17);
                _standings_2017_2018.Add("Stoke", 18);
                _standings_2017_2018.Add("West Brom", 19);
            }

            if (null == _standings_2018_2019)
            {
                _standings_2018_2019 = new Dictionary<string, int>();
                _standings_2018_2019.Add("Manchester City", 0);
                _standings_2018_2019.Add("Liverpool", 1);
                _standings_2018_2019.Add("Chelsea", 2);
                _standings_2018_2019.Add("Tottenham", 3);
                _standings_2018_2019.Add("Arsenal", 4);
                _standings_2018_2019.Add("Manchester Utd", 5);
                _standings_2018_2019.Add("Wolves", 6);
                _standings_2018_2019.Add("Everton", 7);
                _standings_2018_2019.Add("Leicester", 8);
                _standings_2018_2019.Add("West Ham", 9);
                _standings_2018_2019.Add("Watford", 10);
                _standings_2018_2019.Add("Crystal Palace", 11);
                _standings_2018_2019.Add("Newcastle", 12);
                _standings_2018_2019.Add("Bournemouth", 13);
                _standings_2018_2019.Add("Burnley", 14);
                _standings_2018_2019.Add("Southampton", 15);
                _standings_2018_2019.Add("Brighton", 16);
                _standings_2018_2019.Add("Cardiff", 17);
                _standings_2018_2019.Add("Fulham", 18);
                _standings_2018_2019.Add("Huddersfield", 19);
            }

            if (null == _standings_2019_2020)
            {
                _standings_2019_2020 = new Dictionary<string, int>();
                _standings_2019_2020.Add("Liverpool", 0);
                _standings_2019_2020.Add("Manchester City", 1);
                _standings_2019_2020.Add("Manchester Utd", 2);
                _standings_2019_2020.Add("Chelsea", 3);
                _standings_2019_2020.Add("Leicester", 4);
                _standings_2019_2020.Add("Tottenham", 5);
                _standings_2019_2020.Add("Wolves", 6);
                _standings_2019_2020.Add("Arsenal", 7);
                _standings_2019_2020.Add("Sheffield Utd", 8);
                _standings_2019_2020.Add("Burnley", 9);
                _standings_2019_2020.Add("Southampton", 10);
                _standings_2019_2020.Add("Everton", 11);
                _standings_2019_2020.Add("Newcastle", 12);
                _standings_2019_2020.Add("Crystal Palace", 13);
                _standings_2019_2020.Add("Brighton", 14);
                _standings_2019_2020.Add("West Ham", 15);
                _standings_2019_2020.Add("Aston Villa", 16);
                _standings_2019_2020.Add("Bournemouth", 17);
                _standings_2019_2020.Add("Watford", 18);
                _standings_2019_2020.Add("Norwich", 19);
            }
        }

        private static void BuildMatrix(List<Game> games, Dictionary<string, int> standings, double[,] matrix)
        {
            int nRow = 0;
            foreach (string row in standings.Keys)
            {
                int nCol = 0;
                foreach (string col in standings.Keys)
                {
                    if (row.Equals(col))
                    {
                        matrix[nRow, nCol] = 0.0;
                    }
                    else
                    {
                        bool isFound = false;
                        foreach (Game game in games)
                        {
                            if (row.Equals(game.teamHome) && col.Equals(game.teamAway))
                            {
                                matrix[nRow, nCol] = game.goalsHome - game.goalsAway;
                                isFound = true;
                                break;
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("Names mismatch");
                            Environment.Exit(0);
                        }
                    }
                    ++nCol;
                    if (nCol >= 17) break;
                }
                ++nRow;
                if (nRow >= 17) break;
            }
        }

        private static double GetMissed(List<double> x)
        {
            double missed = 0.0;
            foreach (double d in x)
            {
                if (d < -0.1)
                {
                    missed += Math.Abs(d);
                }
            }
            return missed;
        }

        private static double GetHits(List<double> x)
        {
            double hits = 0.0;
            foreach (double d in x)
            {
                if (d > 0.1)
                {
                    hits += Math.Abs(d);
                }
            }
            return hits;
        }

        private static double GetDrawCount(List<double> x)
        {
            int cnt = 0;
            foreach (double v in x)
            {
                if (v > -0.1 && v < 0.1) ++cnt;
            }
            return (double)cnt;
        }

        public static string GetInputOutputVector(double[,] matrix, int row, int col)
        {
            List<double> data = new List<double>();
            List<double> v1 = new List<double>();
            List<double> v2 = new List<double>();
            for (int i = 0; i < 17; ++i)
            {
                v1.Add(matrix[row, i]);
 
            }
            for (int i = 0; i < 17; ++i)
            {
                v2.Add(matrix[i, col]);
            }
            data.Add(GetMissed(v1));
            data.Add(GetHits(v1));
            data.Add(GetDrawCount(v1));

            data.Add(GetMissed(v2));
            data.Add(GetHits(v2));
            data.Add(GetDrawCount(v2));

            //last value is output
            data.Add(matrix[row, col]);
            string sData = "";
            foreach (double v in data)
            {
                sData += String.Format("{0:0.00},", v);
            }
            sData = sData.Substring(0, sData.Length - 1);
            return sData;
        }

        private static void SaveData(StreamWriter sw, double[,] matrix)
        {
            for (int i = 0; i < 17; ++i)
            {
                for (int j = 0; j < 17; ++j)
                {
                    string s = GetInputOutputVector(matrix, i, j);
                    sw.WriteLine(s);
                }
            }
        }

        private static void BuildBigTrainingData()
        {
            string TrainingDataFileName = "../../../DATA/Training-Data.csv";
            using (StreamWriter sw = new StreamWriter(TrainingDataFileName))
            {
                SaveData(sw, _matrix_2012_2013);
                SaveData(sw, _matrix_2013_2014);
                SaveData(sw, _matrix_2014_2015);
                SaveData(sw, _matrix_2015_2016);
                SaveData(sw, _matrix_2016_2017);
                SaveData(sw, _matrix_2017_2018);
                SaveData(sw, _matrix_2018_2019);
 
                sw.Flush();
                sw.Close();
            }
        }

        public static void MakeTrainingData()
        {
            MakeAllStandings();
            DataReader dr = new DataReader();

            List<Game> list;

            list = dr.ProcessFile("../../../DATA/2012-2013.txt");
            BuildMatrix(list, _standings_2012_2013, _matrix_2012_2013);

            list = dr.ProcessFile("../../../DATA/2013-2014.txt");
            BuildMatrix(list, _standings_2013_2014, _matrix_2013_2014);

            list = dr.ProcessFile("../../../DATA/2014-2015.txt");
            BuildMatrix(list, _standings_2014_2015, _matrix_2014_2015);

            list = dr.ProcessFile("../../../DATA/2015-2016.txt");
            BuildMatrix(list, _standings_2015_2016, _matrix_2015_2016);

            list = dr.ProcessFile("../../../DATA/2016-2017.txt");
            BuildMatrix(list, _standings_2016_2017, _matrix_2016_2017);

            list = dr.ProcessFile("../../../DATA/2017-2018.txt");
            BuildMatrix(list, _standings_2017_2018, _matrix_2017_2018);

            list = dr.ProcessFile("../../../DATA/2018-2019.txt");
            BuildMatrix(list, _standings_2018_2019, _matrix_2018_2019);

            BuildBigTrainingData();
        }
    }
}
