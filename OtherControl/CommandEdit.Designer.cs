namespace AutoScreenOperator.OtherControl
{
    partial class CommandEdit
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
            removeButton = new Button();
            addButton = new Button();
            deleteButton = new Button();
            insertNextButton = new Button();
            insertLastButton = new Button();
            SuspendLayout();
            // 
            // removeButton
            // 
            removeButton.Location = new Point(54, 0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(18, 18);
            removeButton.TabIndex = 0;
            removeButton.Text = "-";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(72, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(18, 18);
            addButton.TabIndex = 1;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(18, 18);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "✘";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // insertNextButton
            // 
            insertNextButton.Location = new Point(36, 0);
            insertNextButton.Name = "insertNextButton";
            insertNextButton.Size = new Size(18, 18);
            insertNextButton.TabIndex = 3;
            insertNextButton.Text = "▼";
            insertNextButton.UseVisualStyleBackColor = true;
            insertNextButton.Click += insertNextButton_Click;
            // 
            // insertLastButton
            // 
            insertLastButton.Location = new Point(18, 0);
            insertLastButton.Name = "insertLastButton";
            insertLastButton.Size = new Size(18, 18);
            insertLastButton.TabIndex = 4;
            insertLastButton.Text = "▲";
            insertLastButton.UseVisualStyleBackColor = true;
            insertLastButton.Click += insertLastButton_Click;
            // 
            // CommandEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(insertLastButton);
            Controls.Add(insertNextButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(removeButton);
            Name = "CommandEdit";
            Size = new Size(90, 18);
            ResumeLayout(false);
        }

        #endregion

        private Button removeButton;
        private Button addButton;
        private Button deleteButton;
        private Button insertNextButton;
        private Button insertLastButton;
    }
}
