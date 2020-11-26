using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cislo;

            for(int i = 0; i < 10; i++)
            {
                cislo = rnd.Next(0, 11);
                listBox1.Items.Add(cislo.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pocet = 0;
            int soucet = 0;

            foreach(string i in listBox1.SelectedItems)
            {
                pocet++;
                soucet += Convert.ToInt32(i);
            }
            label1.Text = "Počet všech vybraných položek: " + pocet.ToString();
            label2.Text = "Součet všech vybraných položek: " + soucet.ToString();
        }
    }
}
