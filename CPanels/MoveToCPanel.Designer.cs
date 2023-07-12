namespace AutoScreenOperator
{
    partial class MoveToCPanel
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
            label2 = new Label();
            aimPosTextBox = new InputControl.PointInput();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "指针移动到";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(287, 3);
            timeTextBox.Margin = new Padding(4, 4, 4, 4);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(127, 27);
            timeTextBox.TabIndex = 2;
            timeTextBox.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "时间";
            // 
            // aimPosTextBox
            // 
            aimPosTextBox.Location = new Point(100, 3);
            aimPosTextBox.Margin = new Padding(5, 5, 5, 5);
            aimPosTextBox.Name = "aimPosTextBox";
            aimPosTextBox.Size = new Size(127, 31);
            aimPosTextBox.TabIndex = 4;
            // 
            // MoveToCPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(aimPosTextBox);
            Controls.Add(label2);
            Controls.Add(timeTextBox);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MoveToCPanel";
            Size = new Size(771, 35);
            Leave += MoveToCPanel_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox timeTextBox;
        private Label label2;
        private InputControl.PointInput aimPosTextBox;
    }
}
