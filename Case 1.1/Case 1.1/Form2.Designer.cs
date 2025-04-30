namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMarkA = new System.Windows.Forms.TextBox();
            this.textBoxMarkB = new System.Windows.Forms.TextBox();
            this.textBoxMarkC = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSaveTxt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выполнить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка стали A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Марка стали B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Марка стали C";
            // 
            // textBoxMarkA
            // 
            this.textBoxMarkA.Location = new System.Drawing.Point(156, 35);
            this.textBoxMarkA.Name = "textBoxMarkA";
            this.textBoxMarkA.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarkA.TabIndex = 4;
            // 
            // textBoxMarkB
            // 
            this.textBoxMarkB.Location = new System.Drawing.Point(156, 70);
            this.textBoxMarkB.Name = "textBoxMarkB";
            this.textBoxMarkB.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarkB.TabIndex = 5;
            // 
            // textBoxMarkC
            // 
            this.textBoxMarkC.Location = new System.Drawing.Point(156, 104);
            this.textBoxMarkC.Name = "textBoxMarkC";
            this.textBoxMarkC.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarkC.TabIndex = 6;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(300, 70);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(441, 293);
            this.textBoxResult.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выполнение заказов";
            // 
            // textBoxSaveTxt
            // 
            this.textBoxSaveTxt.Location = new System.Drawing.Point(523, 381);
            this.textBoxSaveTxt.Name = "textBoxSaveTxt";
            this.textBoxSaveTxt.Size = new System.Drawing.Size(218, 44);
            this.textBoxSaveTxt.TabIndex = 9;
            this.textBoxSaveTxt.Text = "Сохранить в txt";
            this.textBoxSaveTxt.UseVisualStyleBackColor = true;
            this.textBoxSaveTxt.Click += new System.EventHandler(this.textBoxSaveTxt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(81, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите план производства";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSaveTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxMarkC);
            this.Controls.Add(this.textBoxMarkB);
            this.Controls.Add(this.textBoxMarkA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Вычисление наиболее выгодного плана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMarkA;
        private System.Windows.Forms.TextBox textBoxMarkB;
        private System.Windows.Forms.TextBox textBoxMarkC;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button textBoxSaveTxt;
        private System.Windows.Forms.Label label5;
    }
}