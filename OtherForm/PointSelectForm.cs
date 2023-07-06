using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.InteropServices;

namespace AutoScreenOperator.OtherForm
{
    public partial class PointSelectForm : Form
    {
        public TextBox updateTextBox { set; get; }
        public Vector2 aimPoint
        { 
            get => Point.Add(Location, Size / 2).ToVector2();
            set => Location = (value - Size.ToVector2() / 2).ToPoint();  
        }
        public string aimPointStr { get { Point p = aimPoint.ToPoint() ;return $"{p.X},{p.Y}"; } }
        public PointSelectForm()
        {
            InitializeComponent();
        }

        private Point offset;
        bool isDrag = false;
        private void PointSelectForm_MouseDown(object sender, MouseEventArgs e)
        {
            offset = new Point(Location.X - MousePosition.X, Location.Y - MousePosition.Y);
            isDrag = true;
        }

        private void PointSelectForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point p = MousePosition;
                p.Offset(offset);
                Location = p;
                if(updateTextBox != null)updateTextBox.Text = aimPointStr;
            }
        }
        private void PointSelectForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void PointSelectForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            this.pictureBox1.BackColor = Color.Transparent;
            this.Size = new(41, 41);
        }
    }
}
