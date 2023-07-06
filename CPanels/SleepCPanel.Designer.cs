namespace AutoScreenOperator
{
    partial class SleepCPanel
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
            timeTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "休眠";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(42, 1);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(100, 23);
            timeTextBox.TabIndex = 1;
            timeTextBox.Text = "0";
            // 
            // SleepCPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeTextBox);
            Controls.Add(label1);
            Name = "SleepCPanel";
            Size = new Size(600, 26);
            Leave += SleepCPanel_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox timeTextBox;
    }
}
