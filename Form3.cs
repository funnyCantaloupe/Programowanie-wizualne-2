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
    public partial class Form3 : Form
    {
        private Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        int cena = 0;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Contains(0))
            {
                cena = 300;
            }
            else if (listView1.SelectedIndices.Contains(1)) 
            {
                cena = 600;
            }
            else if (listView1.SelectedIndices.Contains(2)) 
            {
                cena = 900;
            }
            label2.Text = cena.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.SetCena2(cena);
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("LED ASUS  300 ZŁ");
            listView1.Items.Add("ACER NITRO  600 ZŁ");
            listView1.Items.Add("LG  900 ZŁ");
            this.Controls.Add(listView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
