using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoScreenOperator.CPanels;
using AutoScreenOperator.Imp;
using AutoScreenOperator.Interface;

namespace AutoScreenOperator.OtherControl
{
    public partial class CommandEdit : UserControl
    {
        public Command command { get; set; }
        public CommandEdit(Command c)
        {
            InitializeComponent();
            command = c;
            if (!c.canHaveChildren) { addButton.Enabled = false; removeButton.Enabled = false; }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            command.Delete();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            command.RemoveChild(command.childCount - 1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CommandType type = Program.SelectType(sender);
            if (type == CommandType.None) return;
            command.AddChild(Program.commandF.GetCommand(type));
        }

        private void insertNextButton_Click(object sender, EventArgs e)
        {
            CommandType type = Program.SelectType(sender);
            if (type == CommandType.None) return;
            command.InsertParent(Program.commandF.GetCommand(type));
        }

        private void insertLastButton_Click(object sender, EventArgs e)
        {
            CommandType type = Program.SelectType(sender);
            if (type == CommandType.None) return;
            command.InsertParent(Program.commandF.GetCommand(type),0);
        }
    }
}
