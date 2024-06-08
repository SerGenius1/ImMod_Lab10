namespace Lab10
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
            this.edLamb1 = new System.Windows.Forms.NumericUpDown();
            this.edLamb2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edLamb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLamb2)).BeginInit();
            this.SuspendLayout();
            // 
            // edLamb1
            // 
            this.edLamb1.DecimalPlaces = 1;
            this.edLamb1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edLamb1.Location = new System.Drawing.Point(266, 53);
            this.edLamb1.Margin = new System.Windows.Forms.Padding(4);
            this.edLamb1.Name = "edLamb1";
            this.edLamb1.Size = new System.Drawing.Size(160, 22);
            this.edLamb1.TabIndex = 1;
            this.edLamb1.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // edLamb2
            // 
            this.edLamb2.DecimalPlaces = 1;
            this.edLamb2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edLamb2.Location = new System.Drawing.Point(266, 141);
            this.edLamb2.Margin = new System.Windows.Forms.Padding(4);
            this.edLamb2.Name = "edLamb2";
            this.edLamb2.Size = new System.Drawing.Size(160, 22);
            this.edLamb2.TabIndex = 3;
            this.edLamb2.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Среднее количестов забитых мячей";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(18, 207);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(408, 32);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Начать матч";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "2 Команда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "1 Команда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Среднее количестов забитых мячей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Победила команда ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.edLamb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edLamb1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edLamb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLamb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown edLamb1;
        private System.Windows.Forms.NumericUpDown edLamb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

