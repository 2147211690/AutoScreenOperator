namespace AutoScreenOperator
{
    partial class DragToCPanel
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
            label2 = new Label();
            mouseButtonComboBox = new ComboBox();
            label3 = new Label();
            timeTextBox = new TextBox();
            pointInput = new InputControl.PointInput();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "按住";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 7);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "并移动到";
            // 
            // mouseButtonComboBox
            // 
            mouseButtonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mouseButtonComboBox.Location = new Point(38, 1);
            mouseButtonComboBox.Name = "mouseButtonComboBox";
            mouseButtonComboBox.Size = new Size(100, 25);
            mouseButtonComboBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 7);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 5;
            label3.Text = "时间";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(354, 1);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(100, 23);
            timeTextBox.TabIndex = 6;
            timeTextBox.Text = "0";
            // 
            // pointInput
            // 
            pointInput.Location = new Point(206, 1);
            pointInput.Name = "pointInput";
            pointInput.Size = new Size(99, 26);
            pointInput.TabIndex = 7;
            // 
            // DragToCPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pointInput);
            Controls.Add(timeTextBox);
            Controls.Add(label3);
            Controls.Add(mouseButtonComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DragToCPanel";
            Size = new Size(600, 29);
            Leave += DragToCPanel_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox mouseButtonComboBox;
        private Label label3;
        private TextBox timeTextBox;
        private InputControl.PointInput pointInput;
    }
}
