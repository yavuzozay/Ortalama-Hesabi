using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarfNotuOrtalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        double not,toplam,gort; double toplamKredi;
        double kredi, ortalama;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            this.BackColor = Color.AliceBlue;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8 || (int)e.KeyChar == 44)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8||(int)e.KeyChar==44)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            not = 0;toplam = 0;gort = 0;toplamKredi = 0;kredi = 0;ortalama = 0;
            label4.Text = Convert.ToString(gort);
            label3.Text = Convert.ToString(ortalama);
            listBox1.Items.Clear();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            kredi = Convert.ToDouble(textBox2.Text);
            

            
            if (radioButton1.Checked == true)
            {
                not = 4;
                textBox3.Text = "4";

            }
            if (radioButton2.Checked == true)
            {
                not = 3.7;
                textBox3.Text = "3,7";

            }
            if (radioButton3.Checked == true)
            {
                not = 3.3;
                textBox3.Text = "3,3";

            }
            if (radioButton4.Checked == true)
            {
                not = 3;
                textBox3.Text = "3";

            }
            if (radioButton5.Checked == true)
            {
                not = 2.7;
                textBox3.Text = "2,7";

            }
            if (radioButton6.Checked == true)
            {
                not = 2.3;
                textBox3.Text = "2,3";
            }
            if (radioButton7.Checked == true)
            {
                not = 2;
                textBox3.Text = "2";
            }
            if (radioButton8.Checked == true)
            {
                not = 1.7;
                textBox3.Text = "1,7";
            }
            if (radioButton9.Checked == true)
            {
                not = 1.3;
                textBox3.Text = "1,3";
            }
            if (radioButton10.Checked == true)
            {
                not = 1;
                textBox3.Text = "1";
            }
            if (radioButton11.Checked == true)
            {
                not = 0;
                textBox3.Text = "0";
            }
            if (radioButton12.Checked == true)
            {
                
                
                    not = Convert.ToDouble(textBox3.Text);
                
                }
            if (not < 0 || not > 4)
            {
                MessageBox.Show("Lütfen 0-4 arası değer giriniz");
            }
            else
            {
                toplamKredi += kredi;
                ortalama = not * kredi;
                label3.Text = Convert.ToString(ortalama);
                toplam += ortalama;
                gort = toplam / (toplamKredi);
                label4.Text = Convert.ToString(gort);
                listBox1.Items.Add("Dersin Adı:  " + textBox1.Text + "  Dersin Kredisi  :" + Convert.ToString(textBox2.Text) + "  Dersin Getirisi:  " + Convert.ToString(ortalama) + "  Genel ortalama:  " + Convert.ToString(gort));
            }

        }
    }
}
