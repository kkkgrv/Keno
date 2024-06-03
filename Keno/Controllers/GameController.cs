using KenoGame.Controls;
using KenoGame.Keno.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KenoGame.Keno.Controllers
{
    public class GameController
    {
        private readonly Field field = new Field();
        private readonly Cell cell = new Cell();

        public void InitiateGame(FieldControls fieldControls)
        {
            fieldControls.PlayerBankLabel.Text = field.Player.Bank.ToString();
            fieldControls.BetNumeric.Value = (decimal)field.Bet;
            fieldControls.AttemptNumeric.Value = field.AttemptsCount;
        }

        //Заполняем значения Ставки и Кол-ва попыток из формы
        public void SetBetNumericValue(NumericUpDown betNumeric)
        {
            field.Bet = (double)betNumeric.Value;
            betNumeric.Value = (decimal)field.Bet;
        }

        public void SetAttemptNumericValue(NumericUpDown attemptsNumeric)
        {
            field.AttemptsCount = (int)attemptsNumeric.Value;
            attemptsNumeric.Value = field.AttemptsCount;
        }

        //Отчистить поле
        public void ClearCells(FlowLayoutPanel flowLayoutPanel)
        {
            cell.Clear();
            foreach (var cell in flowLayoutPanel.Controls.OfType<Button>())
            {
                ButtonDraw.EraseOutline(cell);
            }
        }

        //Отрисовываем или стираем рамку вокруг кнопки
        public void CellToggle(Button cell)
        {
            bool isAdded;
            try
            {
                isAdded = this.cell.Add(int.Parse(cell.Text), field.Player.Bank, field.Bet, field.AttemptsCount);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                isAdded = false;
            }
            if (isAdded)
            {
                ButtonDraw.DrawOutline(cell);
            }
            else
            {
                ButtonDraw.EraseOutline(cell);
            }
        }

        //Начать Игру
        public async void Start(FieldControls fieldsControls, FlowLayoutPanel flowLayoutPanel, Label winningLabel)
        {
            if (cell.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну ячейку!");
                return;
            }
            ToggleFieldControls(fieldsControls, flowLayoutPanel);
            winningLabel.Text = "";
            for (int i = 0; i < field.AttemptsCount; i++)
            {
                var currBank = field.Player.MinusBank(field.Bet * cell.Count);
                fieldsControls.PlayerBankLabel.Text = currBank.ToString();
                var winningCells = field.GenerateWinSet();
                await PaintWinningCells(winningCells, flowLayoutPanel);
                var winning = field.CalculateWinning(cell.GetCells(), winningCells, field.Bet);
                winningLabel.Text += $"Попытка {i+1}\nВыигрыш\n{winning}\n\n";
                if (winning > 0)
                {
                    currBank = field.Player.PlusBank(winning);
                    fieldsControls.PlayerBankLabel.Text = currBank.ToString();
                }
                await Task.Delay(1000);
                await PaintWinningCells(winningCells, flowLayoutPanel, true);
            }
            ToggleFieldControls(fieldsControls, flowLayoutPanel, true);
        }

        //Отмечаем выигрышные номера
        private async Task PaintWinningCells(List<int> winningSpots, FlowLayoutPanel flowLayoutPanel, bool isErase = false)
        {
            foreach (var spot in winningSpots)
            {
                var winningSpot = flowLayoutPanel.Controls.Find($"cell{spot}", false).First();
                if (winningSpot is Button winSpotBtn)
                {
                    if (isErase)
                    {
                        ButtonDraw.EraseCircle(winSpotBtn);
                    }
                    else
                    {
                        ButtonDraw.DrawCircle(winSpotBtn);
                        await Task.Delay(500);
                    }
                }
            }
        }

        private void ToggleFieldControls(FieldControls fieldControls, FlowLayoutPanel flowLayoutPanel, bool turnOff = false)
        {
            fieldControls.AttemptNumeric.Enabled = turnOff;
            fieldControls.BetNumeric.Enabled = turnOff;
            flowLayoutPanel.Enabled = turnOff;
        }
    }
}
