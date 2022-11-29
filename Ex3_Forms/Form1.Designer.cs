namespace Ex3_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ForRadioButton = new System.Windows.Forms.RadioButton();
            this.WhileRadioButton = new System.Windows.Forms.RadioButton();
            this.doWhileRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите цикл в поле выше и нажмите кнопку \"Выполнить\". В поле результата появитс" +
    "я столбец чисел";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doWhileRadioButton);
            this.groupBox1.Controls.Add(this.WhileRadioButton);
            this.groupBox1.Controls.Add(this.ForRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(275, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цикла";
            // 
            // ForRadioButton
            // 
            this.ForRadioButton.AutoSize = true;
            this.ForRadioButton.Location = new System.Drawing.Point(7, 31);
            this.ForRadioButton.Name = "ForRadioButton";
            this.ForRadioButton.Size = new System.Drawing.Size(45, 20);
            this.ForRadioButton.TabIndex = 0;
            this.ForRadioButton.TabStop = true;
            this.ForRadioButton.Text = "For";
            this.ForRadioButton.UseVisualStyleBackColor = true;
            // 
            // WhileRadioButton
            // 
            this.WhileRadioButton.AutoSize = true;
            this.WhileRadioButton.Location = new System.Drawing.Point(7, 67);
            this.WhileRadioButton.Name = "WhileRadioButton";
            this.WhileRadioButton.Size = new System.Drawing.Size(59, 20);
            this.WhileRadioButton.TabIndex = 1;
            this.WhileRadioButton.TabStop = true;
            this.WhileRadioButton.Text = "While";
            this.WhileRadioButton.UseVisualStyleBackColor = true;
            // 
            // doWhileRadioButton
            // 
            this.doWhileRadioButton.AutoSize = true;
            this.doWhileRadioButton.Location = new System.Drawing.Point(7, 104);
            this.doWhileRadioButton.Name = "doWhileRadioButton";
            this.doWhileRadioButton.Size = new System.Drawing.Size(84, 20);
            this.doWhileRadioButton.TabIndex = 2;
            this.doWhileRadioButton.TabStop = true;
            this.doWhileRadioButton.Text = "do...While";
            this.doWhileRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 9);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(232, 302);
            this.ResultTextBox.TabIndex = 2;
            this.ResultTextBox.Text = "";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(363, 277);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(112, 34);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Выполнить";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 323);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton doWhileRadioButton;
        private System.Windows.Forms.RadioButton WhileRadioButton;
        private System.Windows.Forms.RadioButton ForRadioButton;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Button RunButton;
    }
}

