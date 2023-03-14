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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cena1 = 0;
        int cena2 = 0;

        public void SetCena1(int cena)
        {
            cena1 = cena;
            label_form1.Text = (cena1 + cena2).ToString();
        }

        public void SetCena2(int cena)
        {
            cena2 = cena;
            label_form1.Text = (cena1 + cena2).ToString();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
