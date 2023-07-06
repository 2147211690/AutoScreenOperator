namespace AutoScreenOperator
{
    partial class RepeatCPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            countTextBox = new TextBox();
            panel = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "循环次数";
            // 
            // countTextBox
            // 
            countTextBox.Location = new Point(68, 1);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(100, 23);
            countTextBox.TabIndex = 1;
            countTextBox.Text = "1";
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Location = new Point(24, 26);
            panel.Name = "panel";
            panel.Size = new Size(0, 0);
            panel.TabIndex = 2;
            // 
            // RepeatCPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel);
            Controls.Add(countTextBox);
            Controls.Add(label1);
            Name = "RepeatCPanel";
            Size = new Size(600, 29);
            Leave += RepeatCPanel_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox countTextBox;
        public Panel panel;
    }
}
