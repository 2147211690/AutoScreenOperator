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
    public partial class DragToCPanel : CommandPanel
    {
        public override Command command => _command;
        private DragToCommand _command;
        public DragToCPanel(DragToCommand c)
        {
            InitializeComponent();
            _command = c;
            SummonCommandEidt();
            CPanelResource.SetMButtonComboBox(mouseButtonComboBox);
        }

        public override void SetCommandValue()
        {
            _command.aimPos = pointInput.aimPoint;
            _command.mButton = (MButtons)mouseButtonComboBox.SelectedIndex;
            _command.time = float.Parse(timeTextBox.Text);
        }


        private void DragToCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }

        private void commandEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
