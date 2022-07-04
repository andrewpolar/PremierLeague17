using System;
using System.Collections.Generic;
using System.Text;

namespace PremierLeague17
{
    class Game: IComparable
    {
        public string teamHome { get; set; }
        public string teamAway { get; set; }
        public DateTime dt { get; set; }
        public int goalsHome { get; set; }
        public int goalsAway { get; set; }

        public int Bet1 { get; set; }
        public int BetX { get; set; }
        public int Bet2 { get; set; }

        public Game(string TH, string TA, DateTime DT, int GH, int GA, int BET1, int BETX, int BET2)
        {
            teamHome = TH;
            teamAway = TA;
            dt = DT;
            goalsHome = GH;
            goalsAway = GA;
            Bet1 = BET1;
            BetX = BETX;
            Bet2 = BET2;
        }

        public void ShowData()
        {
            Console.WriteLine("{0}-{1}, {2}, {3}:{4}", teamHome, teamAway, dt, goalsHome, goalsAway);
        }

        public string GetGameInfo()
        {
            return String.Format("{0}-{1}, {2}, {3}:{4}, 1X2 = {5},{6},{7}", teamHome, teamAway, dt, goalsHome, goalsAway, Bet1, BetX, Bet2);
        }

        public int CompareTo(object obj)
        {
            Game g = (Game)(obj);
            if (g.dt > this.dt) return -1;
            if (g.dt < this.dt) return 1;
            return 0;
        }
    }
}
