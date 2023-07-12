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
    public partial class ClickCPanel : CommandPanel
    {
        public ClickCPanel(ClickCommand c)
        {
            InitializeComponent();
            _command = c;
            SummonCommandEidt();
            CPanelResource.SetMButtonComboBox(mouseButtonComboBox);
            SetCommandValue();
        }
        public override Command command => _command;
        private ClickCommand _command;
        public override void SetCommandValue()
        {
            _command.mButton = (MButtons)mouseButtonComboBox.SelectedIndex;
        }

        private void ClickCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }
    }
}
