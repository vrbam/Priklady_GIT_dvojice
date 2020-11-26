using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mocnina = Convert.ToInt32(comboBox1.SelectedItem);
            label1.Text = mocnina.ToString();

            foreach(object o in panel1.Controls)
            {
                if(o is TextBox)
                    (o as TextBox).Text = Mocnina(Convert.ToInt32((o as TextBox).Text), mocnina).ToString();
            }

            //textBox1.Text = Mocnina(Convert.ToInt32(textBox1.Text), mocnina).ToString();
            //textBox2.Text = Mocnina(Convert.ToInt32(textBox2.Text), mocnina).ToString();
            //textBox3.Text = Mocnina(Convert.ToInt32(textBox3.Text), mocnina).ToString();
        }

        private int Mocnina(int zaklad, int mocnina)
        {
            int vysledek = 1;
            for (int i = 0; i < mocnina; i++)
            {
                vysledek *= zaklad;
            }
            return vysledek;
        }
    }
}
