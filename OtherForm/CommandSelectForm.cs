using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScreenOperator.OtherForm
{
    public partial class CommandSelectForm : Form
    {
        public int selectedIndex { get => listBox.SelectedIndex; }
        public CommandSelectForm()
        {
            InitializeComponent();
            Program.commandF.SetFactoryList(listBox);
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
