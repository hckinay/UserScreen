using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControllPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 3;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                hak--;
                MessageBox.Show("Kullanıcı adı veya şifre yanlış! Kalan Hakkınız="+hak);

            }
            else if (textBox1.Text == "atabay" && textBox2.Text == "1234")
            {
                MessageBox.Show("giriş yapılmıştır.");
                
            }
            else
            {
                hak--;
                MessageBox.Show("Yanlış kullanıcı adı veya şifre. Kalan hakkınız = " +hak);

            }
            if (hak==0)
                    {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formyeni = new Form2();
            formyeni.Show();
        }
    }
}
