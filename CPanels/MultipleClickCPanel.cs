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
    public partial class MultipleClickCPanel : CommandPanel
    {
        public MultipleClickCPanel(MultipleClickCommand c)
        {
            InitializeComponent();
            _command = c;
            SummonCommandEidt();
            CPanelResource.SetMButtonComboBox(mouseButtonComboBox);
        }
        public override Command command => _command;
        private MultipleClickCommand _command;

        public override void SetCommandValue()
        {
            _command.count = int.Parse(countTextBox.Text);
            _command.time = float.Parse(timeTextBox.Text);
            _command.mButton = (MButtons)mouseButtonComboBox.SelectedIndex;
        }
        private void MultipleClickCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }
    }
}
