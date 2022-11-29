namespace Ex1_Forms
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
            this.label2 = new System.Windows.Forms.Label();
            this.XNumeric = new System.Windows.Forms.NumericUpDown();
            this.YNumeric = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.XNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите первую точку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите вторую точку:";
            // 
            // XNumeric
            // 
            this.XNumeric.DecimalPlaces = 2;
            this.XNumeric.Location = new System.Drawing.Point(157, 9);
            this.XNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.XNumeric.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.XNumeric.Name = "XNumeric";
            this.XNumeric.Size = new System.Drawing.Size(120, 20);
            this.XNumeric.TabIndex = 2;
            // 
            // YNumeric
            // 
            this.YNumeric.DecimalPlaces = 2;
            this.YNumeric.Location = new System.Drawing.Point(157, 40);
            this.YNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.YNumeric.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.YNumeric.Name = "YNumeric";
            this.YNumeric.Size = new System.Drawing.Size(120, 20);
            this.YNumeric.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(107, 90);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(88, 35);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Проверить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex1_Forms.Properties.Resources._123123;
            this.pictureBox1.Location = new System.Drawing.Point(327, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 111);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 137);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.YNumeric);
            this.Controls.Add(this.XNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Башилов Неделя 1 Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.XNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown XNumeric;
        private System.Windows.Forms.NumericUpDown YNumeric;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

