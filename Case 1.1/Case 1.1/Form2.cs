using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
        }
        private void Form2_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Reader reader = new Reader();
        Result result = new Result();
        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxMarkA.Text, out Reader.Mark_A);
            double.TryParse(textBoxMarkB.Text, out Reader.Mark_B);
            double.TryParse(textBoxMarkC.Text, out Reader.Mark_C);
            if (Reader.Mark_A <= 0 && Reader.Mark_B <= 0 || Reader.Mark_C <= 0)
            {
                textBoxResult.Text = "Ошибка, неправильный запрос!";
            }
            else
            {
                result.result();
                textBoxResult.Text = Result.plan;
            }
        }

        private void textBoxSaveTxt_Click(object sender, EventArgs e)
        {
            if(Result.proverka == true)
            {
                reader.Read();
                result.minus();
                textBoxResult.Text = Result.plan;
                return;
            }
            if(Result.proverka == false)
            {
                textBoxResult.Text = "Заказ нельзя сохранить в текстовый документ, так как он не был выполнен!";           
            }
        }
    }
}
