using System;
using System.Collections.Generic;


namespace KenoGame.Keno
{
    internal class Cell
    {
        private readonly List<int> cells = new List<int>();

        public int Count
        {
            get => cells.Count;
        }

        public bool Add(int val, double bank, double bet, int attempts)
        {
            if (IsValidCell(val) == false)
            {
                throw new ArgumentException("Неверное значение");
            }
            else if (cells.Contains(val))
            {
                cells.Remove(val);
                return false;
            }
            else if (bank < bet * (Count + 1) * attempts)
            {
                throw new Exception("Недостаточно средств в банке");
            }
            else if (cells.Count == 15)
            {
                throw new Exception("Выбрано максимальное количество ячеек");
            }
            
            cells.Add(val);
            return true;
        }

        bool IsValidCell(int val)
        {
            return val >= 1 && val <= 80;
        }

        public List<int> GetCells()
        {
            return cells;
        }

        public void Clear()
        {
            cells.Clear();
        }
    }
}
