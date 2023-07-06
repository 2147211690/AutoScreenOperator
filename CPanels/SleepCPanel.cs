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

namespace AutoScreenOperator
{
    public partial class SleepCPanel : CommandPanel
    {
        public SleepCPanel(SleepCommand c) { InitializeComponent(); _command = c; SummonCommandEidt(); }
        public override Command command => _command;
        private SleepCommand _command;
        public override void SetCommandValue()
        {
            _command.sleepTime = float.Parse(timeTextBox.Text);
        }

        private void SleepCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }
    }
}
