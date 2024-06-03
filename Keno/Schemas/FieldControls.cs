using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenoGame.Keno.Schemas
{
    //Класс обертка для контроллов на форме
    public class FieldControls
    {
        public Label PlayerBankLabel { get; private set; }
        public NumericUpDown BetNumeric { get; private set; }
        public NumericUpDown AttemptNumeric { get; private set; }

        public FieldControls(Label playerBankLabel, NumericUpDown betNumeric, NumericUpDown attemptNumeric)
        {
            PlayerBankLabel = playerBankLabel;
            BetNumeric = betNumeric;
            AttemptNumeric = attemptNumeric;
        }
    }
}
