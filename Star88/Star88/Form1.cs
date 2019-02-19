using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Army;

namespace Star88
{
     partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] info = new string [10];
            Soldier[] array0 = new Soldier[10];
            int percent_S = (int)numericUpDown1.Value;
            int percent_C = 100 - percent_S;
            for (int i = 0; i < 10; ++i)
            {
                if (rnd.Next(1, 101) > percent_S)
                {
                    array0[i] = new Commander(rnd.Next(1,11));
                } else
                {
                    array0[i] = new Squaddie();
                }

                info[i] = array0[i].ToString();
            }

            textBox3.Lines = (string[]) info.Clone();

            Array.Sort(array0,(str1,str2)=> str1.rank.CompareTo(str2.rank));
            Array.Reverse(array0);

            for (int i = 0; i < 10; ++i)
            {
                info[i] = array0[i].ToString();
            }

            textBox1.Lines = (string[])info.Clone();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }
    }
}
