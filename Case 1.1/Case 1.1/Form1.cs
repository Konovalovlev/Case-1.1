using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            File.WriteAllText(reader._wareHousePath, string.Empty);
            double.TryParse(textBoxRuda.Text, out DostupResur._ruda);
            double.TryParse(textBoxNikel.Text, out DostupResur._nikel);
            double.TryParse(textBoxChrome.Text, out DostupResur._chrome);
            double.TryParse(textBoxMarganec.Text, out DostupResur._marganec);
            double.TryParse(textBoxPech.Text, out DostupResur._pech);
            double.TryParse(textBoxConvert.Text, out DostupResur._convert);
            double.TryParse(textBoxProkat.Text, out DostupResur._prokat);
            if(DostupResur._ruda <= 0 
              || DostupResur._nikel <= 0 
              || DostupResur._chrome <= 0 
              || DostupResur._marganec <= 0 
              || DostupResur._pech <= 0 
              || DostupResur._convert <= 0 
              || DostupResur._prokat <= 0)
            {
                textBoxProverka.Text = "Ошибка, неправильно введённые ресурсы";
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
