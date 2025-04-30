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
            File.WriteAllText(reader.WareHousePath, string.Empty);
            double.TryParse(textBoxRuda.Text, out DostupResur.ruda);
            double.TryParse(textBoxNikel.Text, out DostupResur.nikel);
            double.TryParse(textBoxChrome.Text, out DostupResur.chrome);
            double.TryParse(textBoxMarganec.Text, out DostupResur.marganec);
            double.TryParse(textBoxPech.Text, out DostupResur.pech);
            double.TryParse(textBoxConvert.Text, out DostupResur.convert);
            double.TryParse(textBoxProkat.Text, out DostupResur.prokat);
            if(DostupResur.ruda <= 0 
              || DostupResur.nikel <= 0 
              || DostupResur.chrome <= 0 
              || DostupResur.marganec <= 0 
              || DostupResur.pech <= 0 
              || DostupResur.convert <= 0 
              || DostupResur.prokat <= 0)
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
