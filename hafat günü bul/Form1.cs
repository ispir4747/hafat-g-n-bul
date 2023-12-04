using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafat_günü_bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hafta = Convert.ToInt32(textBox1.Text);
            switch (hafta)
            {
                case 1:{ MessageBox.Show("pazartersi"); } break;
                case 2:{ MessageBox.Show("salı "); } break;
                case 3:{ MessageBox.Show("çarşamba"); } break;
                case 4:{ MessageBox.Show("perşempe"); } break;
                case 5:{ MessageBox.Show("cuma"); } break;
                case 6:{ MessageBox.Show("cumatersi"); } break;
                case 7:{ MessageBox.Show("pazar"); } break;
                default:
                    { MessageBox.Show("öyle bir gün sayısı mı var amk"); } break;
            }
        }
    }
}
