using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoScreenOperator.CPanels;
using AutoScreenOperator.OtherControl;

namespace AutoScreenOperator
{
    public partial class MoveToCPanel : CommandPanel
    {
        public MoveToCPanel(MoveToCommand c) { InitializeComponent(); _command = c; SummonCommandEidt(); }
        public override Command command { get => _command; }
        private MoveToCommand _command;

        public override void SetCommandValue()
        {
            _command.aimPos = aimPosTextBox.aimPoint;
            _command.time = float.Parse(timeTextBox.Text);
        }
        private void MoveToCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }
    }
}
