using System;
using System.Collections.Generic;
using System.Linq;

namespace KenoGame.Keno
{
    public class Field
    {
        private const double maxBet = 50;
        private const int maxAttempts = 10;
        private int attempts = 1;
        private double bet = 0.5;


        public Player Player { get; } = new Player(bank:100);

        public double Bet
        {
            get => bet;
            set
            {
                if (value <= maxBet)
                {
                    bet = Player.Bank >= value ? value : Player.Bank;
                }
                else
                {
                    bet = Player.Bank <= maxBet ? Player.Bank : maxBet;
                }
            }
        }

        public int AttemptsCount
        {
            get => attempts;
            set
            {
                int maxAvailableAttemptForPlayer = (int)Math.Floor(Player.Bank / bet);
                attempts = value;
                if (value > maxAttempts)
                {
                    attempts = maxAttempts;
                }
                else if (value > maxAvailableAttemptForPlayer)
                {
                    attempts = maxAvailableAttemptForPlayer;
                }
            }
        }

        public List<int> GenerateWinSet(int n = 15)
        {
            List<int> winCells = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var spot = rnd.Next(1, 80);
                if (winCells.Contains(spot))
                {
                    i -= 1;
                }
                else
                {
                    winCells.Add(spot);
                }
            }
            return winCells;
        }

        public double CalculateWinning(List<int> cells, List<int> winningCells, double bet)
        {
            var crossing = cells.Intersect(winningCells).ToList();
            var winning = Math.Floor(Math.Pow((double)crossing.Count() * 3 / cells.Count(), 2) * (1 + bet));
            return winning;
        }
    }
}
