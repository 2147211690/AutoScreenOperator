namespace AutoScreenOperator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            executeButton = new Button();
            mainPanel = new Panel();
            runTimeTextBox = new TextBox();
            label1 = new Label();
            checkEnableTimerBox = new CheckBox();
            panel1 = new Panel();
            millisecondUpDown = new NumericUpDown();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)millisecondUpDown).BeginInit();
            SuspendLayout();
            // 
            // executeButton
            // 
            executeButton.Dock = DockStyle.Bottom;
            executeButton.Location = new Point(0, 569);
            executeButton.Margin = new Padding(4);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(1049, 31);
            executeButton.TabIndex = 0;
            executeButton.Text = "运行";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.AutoSize = true;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1049, 569);
            mainPanel.TabIndex = 1;
            // 
            // runTimeTextBox
            // 
            runTimeTextBox.Location = new Point(3, 70);
            runTimeTextBox.Name = "runTimeTextBox";
            runTimeTextBox.Size = new Size(219, 27);
            runTimeTextBox.TabIndex = 0;
            runTimeTextBox.Text = "00:00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "定时时间(hh:mm:ss)";
            // 
            // checkEnableTimerBox
            // 
            checkEnableTimerBox.AutoSize = true;
            checkEnableTimerBox.Location = new Point(3, 20);
            checkEnableTimerBox.Name = "checkEnableTimerBox";
            checkEnableTimerBox.Size = new Size(91, 24);
            checkEnableTimerBox.TabIndex = 3;
            checkEnableTimerBox.Text = "启用定时";
            checkEnableTimerBox.UseVisualStyleBackColor = true;
            checkEnableTimerBox.CheckedChanged += checkEnableTimerBox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(millisecondUpDown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkEnableTimerBox);
            panel1.Controls.Add(runTimeTextBox);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(804, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 569);
            panel1.TabIndex = 4;
            // 
            // millisecondUpDown
            // 
            millisecondUpDown.Location = new Point(3, 126);
            millisecondUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            millisecondUpDown.Name = "millisecondUpDown";
            millisecondUpDown.Size = new Size(150, 27);
            millisecondUpDown.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 103);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "毫秒";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 600);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Controls.Add(executeButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)millisecondUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button executeButton;
        public Panel mainPanel;
        private TextBox runTimeTextBox;
        private Label label1;
        private CheckBox checkEnableTimerBox;
        private Panel panel1;
        private NumericUpDown millisecondUpDown;
        private Label label2;
    }
}