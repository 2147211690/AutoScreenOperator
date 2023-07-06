using System.Numerics;
using AutoScreenOperator.Imp;
using AutoScreenOperator.Interface;

namespace AutoScreenOperator
{
    public partial class MainForm : Form
    {
        Command enterCommand;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Command.mouseImp = new WindowMouseOperator();
            IFactory f = Program.commandF;


            enterCommand = f.GetRepeatCommand();
            enterCommand.panel.Parent = mainPanel;


        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            enterCommand.Execute();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            mainPanel.Size = new Size(Size.Width - 120, Size.Height);
        }
    }
}