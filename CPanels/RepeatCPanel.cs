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
    public partial class RepeatCPanel : CommandPanel
    {
        public RepeatCPanel(RepeatCommand c) { InitializeComponent(); _command = c; SummonCommandEidt(); }
        public override Command command => _command;
        private RepeatCommand _command;

        public override void AddChild(CommandPanel p) => panel.Controls.Add(p);
        public override void RemoveChild(CommandPanel p) => panel.Controls.Remove(p);

        public override void SetCommandValue()
        {
            
            _command.repeatCount = int.Parse(countTextBox.Text);
        }
        public override void Review()
        {
            CreateGraphics().DrawLine(edgeLinePen, new Point(15, 20), new Point(15, Size.Height - 10));
        }
        private void RepeatCPanel_Leave(object sender, EventArgs e)
        {
            SetCommandValue();
        }
        private Pen edgeLinePen = new(Color.Blue, 3);
    }
}
