namespace AutoScreenOperator.CPanels
{
    partial class ChangeStateCPanel
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
            mouseStateComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "改变按键";
            // 
            // mouseButtonComboBox
            // 
            mouseButtonComboBox.FormattingEnabled = true;
            mouseButtonComboBox.Location = new Point(68, 1);
            mouseButtonComboBox.Name = "mouseButtonComboBox";
            mouseButtonComboBox.Size = new Size(121, 23);
            mouseButtonComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 4);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "的状态为";
            // 
            // mouseStateComboBox
            // 
            mouseStateComboBox.FormattingEnabled = true;
            mouseStateComboBox.Location = new Point(260, 1);
            mouseStateComboBox.Name = "mouseStateComboBox";
            mouseStateComboBox.Size = new Size(121, 23);
            mouseStateComboBox.TabIndex = 3;
            // 
            // ChangeStateCPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mouseStateComboBox);
            Controls.Add(label2);
            Controls.Add(mouseButtonComboBox);
            Controls.Add(label1);
            Name = "ChangeStateCPanel";
            Size = new Size(600, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox mouseButtonComboBox;
        private Label label2;
        private ComboBox mouseStateComboBox;
    }
}
