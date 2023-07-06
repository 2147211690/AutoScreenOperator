using AutoScreenOperator.OtherForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScreenOperator.InputControl
{
    public partial class PointInput : UserControl
    {
        private static Regex checkRegex = new Regex(@"^\d+,\d+$");
        private static string defaultStr = "0,0";
        public Vector2 aimPoint { get; private set; }
        public PointInput()
        {
            InitializeComponent();
            textBox1_Leave(this,EventArgs.Empty);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!checkRegex.IsMatch(textBox1.Text)) { textBox1.Text = defaultStr; }
            aimPoint = textBox1.Text.ToVector2();
            Program.pointSelector.updateTextBox = null;
            Program.pointSelector.Visible = false;
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.pointSelector.Visible = true;
            Program.pointSelector.aimPoint = aimPoint;
            Program.pointSelector.updateTextBox = textBox1;
        }
    }
}
