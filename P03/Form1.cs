using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*3.	Na formuláři je ListBox1, jehož prvky jsou libovolné texty
            a komponenta groupBox1.  Do groupBox1 umístěte několik komponent
            TextBox obsahující celé číslo A několik komponent Label 
            (Počet komponent je libovolný).
            Pomocí tlačítka spočtěte aritmetický průměr všech čísel v textBoxech
            a do všech komponent label zapište text, který je vybrán v Listbox.*/

            string x = listBox1.Text;
            double soucet = 0;
            int pocet = 0;
            
            foreach(Control con in groupBox1.Controls) 
            {
                if(con is TextBox)
                {
                    soucet += Convert.ToInt32((con as TextBox).Text);
                    pocet++;

                }
                if (con is Label)
                {
                    (con as Label).Text = x;
                }

            }
            if (pocet != 0) MessageBox.Show("Arit. průměr je " + soucet / pocet);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }
    }
}
