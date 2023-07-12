using System.Numerics;
using AutoScreenOperator.Imp;
using AutoScreenOperator.Interface;
using System.Threading;

namespace AutoScreenOperator
{
    public partial class MainForm : Form
    {
        Command enterCommand;
        int h, m, s;
        Thread timeRunThread;
        bool timeRunLive = false;
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Command.mouseImp = new WindowMouseOperator();
            IFactory f = Program.commandF;


            enterCommand = f.GetRepeatCommand();
            enterCommand.panel.Parent = mainPanel;
            enterCommand.AddChild(f.GetMoveToCommand());
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            enterCommand.Execute();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            mainPanel.Size = new Size(Size.Width - 120, Size.Height);
        }


        private void checkEnableTimerBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isOk = true;
            if (checkEnableTimerBox.Checked)
            {
                string[] strs = runTimeTextBox.Text.Split(new char[] { ':', '：' });
                if (strs.Length == 3)
                {
                    try
                    {
                        h = int.Parse(strs[0]);
                        m = int.Parse(strs[1]);
                        s = int.Parse(strs[2]);
                    }
                    catch
                    {
                        h = m = s = 0;
                        isOk = false;
                    }
                }
                else isOk = false;
                if (isOk)
                {
                    timeRunThread = new(CheckTimeRun);
                    timeRunThread.Start();
                }
                else
                {
                    runTimeTextBox.Text = "00:00:00";
                    checkEnableTimerBox.Checked = false;
                }
            }
            else
            {
                timeRunLive = false;
            }
        }
        private void CheckTimeRun()
        {
            DateTime aimTime = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, h, m, s, (int)millisecondUpDown.Value);
            timeRunLive = true;
            while (true)
            {
                TimeSpan span = aimTime - DateTime.Now;
                double seconds = span.TotalMilliseconds;
                if (!timeRunLive) return;
                if (seconds <= 0)
                {
                    enterCommand.Execute();
                    checkEnableTimerBox.Checked = false;
                }
            }
        }
    }
}