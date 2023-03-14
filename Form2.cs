using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programowanie_wizualne_2
{
    public partial class Form2 : Form
    {

        int cena = 0;
        int temp_radio;
        int temp_checkbox = 0;
        int temp_combo;

        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
       
        private void Form2_Load(object sender, EventArgs e) 
        {
            comboBox1.Items.Add("RTX 3060  1700 ZŁ");
            comboBox1.Items.Add("RTX 3070  3200 ZŁ");
            comboBox1.Items.Add("RTX 4090  8900 ZŁ");
            this.Controls.Add(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.SetCena1(cena);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                temp_checkbox = temp_checkbox + 15;
            }
            else
            {
                temp_checkbox = temp_checkbox - 15;
            }
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                temp_combo = 1700;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                temp_combo = 3200;
            }
            else
            {
                temp_combo = 8900;
            }
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            temp_radio = 100;
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            temp_radio = 200;
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            temp_radio = 400;
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                temp_checkbox = temp_checkbox + 40;
            }
            else
            {
                temp_checkbox = temp_checkbox - 40;
            }
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                temp_checkbox = temp_checkbox + 70;
            }
            else
            {
                temp_checkbox = temp_checkbox - 70;
            }
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                temp_checkbox = temp_checkbox + 120;
            }
            else
            {
                temp_checkbox = temp_checkbox - 120;
            }
            cena = temp_radio + temp_checkbox + temp_combo;
            label2.Text = cena.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
