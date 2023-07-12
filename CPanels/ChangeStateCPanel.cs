using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScreenOperator.CPanels
{
    public partial class ChangeStateCPanel : CommandPanel
    {
        public ChangeStateCPanel(ChangeStateCommand c)
        {
            InitializeComponent();
            _command = c;
            SummonCommandEidt();
            CPanelResource.SetMButtonComboBox(mouseButtonComboBox);
            CPanelResource.SetMStateComboBox(mouseStateComboBox);
            SetCommandValue();
        }
        public override Command command => _command;
        private ChangeStateCommand _command;
        public override void SetCommandValue()
        {
            _command.mButton = (MButtons)mouseButtonComboBox.SelectedIndex;
            _command.mState = (MState)mouseStateComboBox.SelectedIndex;
        }

        private void ChangeStateCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }
    }
}
