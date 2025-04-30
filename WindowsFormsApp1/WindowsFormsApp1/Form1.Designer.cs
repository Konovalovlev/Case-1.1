namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRuda = new System.Windows.Forms.TextBox();
            this.textBoxNikel = new System.Windows.Forms.TextBox();
            this.textBoxChrome = new System.Windows.Forms.TextBox();
            this.textBoxMarganec = new System.Windows.Forms.TextBox();
            this.textBoxPech = new System.Windows.Forms.TextBox();
            this.textBoxConvert = new System.Windows.Forms.TextBox();
            this.textBoxProkat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProverka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(683, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить ресуры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Руда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Никель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Хром";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Марганец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Время работы доменной печи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Время работы конвертера";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Время работного прокатного станка";
            // 
            // textBoxRuda
            // 
            this.textBoxRuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRuda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRuda.Location = new System.Drawing.Point(55, 95);
            this.textBoxRuda.Name = "textBoxRuda";
            this.textBoxRuda.Size = new System.Drawing.Size(59, 25);
            this.textBoxRuda.TabIndex = 8;
            this.textBoxRuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNikel
            // 
            this.textBoxNikel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNikel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNikel.Location = new System.Drawing.Point(55, 123);
            this.textBoxNikel.Name = "textBoxNikel";
            this.textBoxNikel.Size = new System.Drawing.Size(59, 25);
            this.textBoxNikel.TabIndex = 9;
            this.textBoxNikel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChrome
            // 
            this.textBoxChrome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChrome.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChrome.Location = new System.Drawing.Point(55, 158);
            this.textBoxChrome.Name = "textBoxChrome";
            this.textBoxChrome.Size = new System.Drawing.Size(59, 25);
            this.textBoxChrome.TabIndex = 10;
            this.textBoxChrome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMarganec
            // 
            this.textBoxMarganec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarganec.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarganec.Location = new System.Drawing.Point(55, 189);
            this.textBoxMarganec.Name = "textBoxMarganec";
            this.textBoxMarganec.Size = new System.Drawing.Size(59, 25);
            this.textBoxMarganec.TabIndex = 11;
            this.textBoxMarganec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPech
            // 
            this.textBoxPech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPech.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPech.Location = new System.Drawing.Point(55, 221);
            this.textBoxPech.Name = "textBoxPech";
            this.textBoxPech.Size = new System.Drawing.Size(59, 25);
            this.textBoxPech.TabIndex = 12;
            this.textBoxPech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxConvert
            // 
            this.textBoxConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConvert.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConvert.Location = new System.Drawing.Point(55, 255);
            this.textBoxConvert.Name = "textBoxConvert";
            this.textBoxConvert.Size = new System.Drawing.Size(59, 25);
            this.textBoxConvert.TabIndex = 13;
            this.textBoxConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProkat
            // 
            this.textBoxProkat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProkat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProkat.Location = new System.Drawing.Point(55, 289);
            this.textBoxProkat.Name = "textBoxProkat";
            this.textBoxProkat.Size = new System.Drawing.Size(59, 25);
            this.textBoxProkat.TabIndex = 15;
            this.textBoxProkat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(51, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Введите доступные ресурсы";
            // 
            // textBoxProverka
            // 
            this.textBoxProverka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProverka.Location = new System.Drawing.Point(435, 54);
            this.textBoxProverka.Multiline = true;
            this.textBoxProverka.Name = "textBoxProverka";
            this.textBoxProverka.ReadOnly = true;
            this.textBoxProverka.Size = new System.Drawing.Size(303, 260);
            this.textBoxProverka.TabIndex = 17;
            this.textBoxProverka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProverka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxProkat);
            this.Controls.Add(this.textBoxConvert);
            this.Controls.Add(this.textBoxPech);
            this.Controls.Add(this.textBoxMarganec);
            this.Controls.Add(this.textBoxChrome);
            this.Controls.Add(this.textBoxNikel);
            this.Controls.Add(this.textBoxRuda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ввод доступных ресурсов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRuda;
        private System.Windows.Forms.TextBox textBoxNikel;
        private System.Windows.Forms.TextBox textBoxChrome;
        private System.Windows.Forms.TextBox textBoxMarganec;
        private System.Windows.Forms.TextBox textBoxPech;
        private System.Windows.Forms.TextBox textBoxConvert;
        private System.Windows.Forms.TextBox textBoxProkat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProverka;
    }
}

