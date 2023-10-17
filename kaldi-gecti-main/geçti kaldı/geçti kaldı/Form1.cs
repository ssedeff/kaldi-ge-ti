using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geçti_kaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float yazili1, yazili2, ortalam;
            yazili1 = Convert.ToSingle(textBox1.Text);
            yazili2=Convert.ToSingle(textBox3.Text);
            ortalam = (yazili1 + yazili2) / 2;

            if (ortalam > 50)
            {
                label.Text = "DURUM: GEÇTİ";
                this.BackColor = Color.Green;
            }
            else
            {
                label.Text = "DURUM: KALDI";
                this.BackColor = Color.Red;
        
            }
            label4.Text = "ORTALAMA :" + ortalam.ToString();
        }

    }
}
