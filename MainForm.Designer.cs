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
            executeButton = new Button();
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // executeButton
            // 
            executeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            executeButton.Location = new Point(713, 415);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(75, 23);
            executeButton.TabIndex = 0;
            executeButton.Text = "button1";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(707, 450);
            mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(executeButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Button executeButton;
        public Panel mainPanel;
    }
}