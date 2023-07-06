namespace AutoScreenOperator
{
    partial class MultipleClickCPanel
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
            mouseButtonComboBox = new ComboBox();
            label2 = new Label();
            countTextBox = new TextBox();
            label3 = new Label();
            timeTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "点击";
            // 
            // mouseButtonComboBox
            // 
            mouseButtonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mouseButtonComboBox.FormattingEnabled = true;
            mouseButtonComboBox.Location = new Point(39, 1);
            mouseButtonComboBox.Name = "mouseButtonComboBox";
            mouseButtonComboBox.Size = new Size(121, 23);
            mouseButtonComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 7);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "次数";
            // 
            // countTextBox
            // 
            countTextBox.Location = new Point(208, 1);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(100, 23);
            countTextBox.TabIndex = 3;
            countTextBox.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 4);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "时间";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(353, 1);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(100, 23);
            timeTextBox.TabIndex = 5;
            timeTextBox.Text = "0";
            // 
            // MultipleClickCPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeTextBox);
            Controls.Add(label3);
            Controls.Add(countTextBox);
            Controls.Add(label2);
            Controls.Add(mouseButtonComboBox);
            Controls.Add(label1);
            Name = "MultipleClickCPanel";
            Size = new Size(600, 26);
            Leave += MultipleClickCPanel_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox mouseButtonComboBox;
        private Label label2;
        private TextBox countTextBox;
        private Label label3;
        private TextBox timeTextBox;
    }
}
