using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix3x3;

namespace Startsev_8
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int min, max;
            try
            {
                min = getValueFromTB(textBox1);
                max = getValueFromTB(textBox1);
                if (min > max)
                {
                    throw new ArgumentException("min > max");
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            double[,] mtr = new double[3, 3];
            for (int i = 0; i < mtr.GetLength(0); i++)
            {
                for (int j = 0; j < mtr.GetLength(1); j++)
                {
                    mtr[i, j] = rnd.Next(min, max) + rnd.NextDouble();
                }
            }

            Matrix A = new Matrix(mtr);
            Matrix B = A.getMinors();

            string[] strArr1 = A.ToString().Split('\n');
            string[] strArr2 = B.ToString().Split('\n');

            textBox3.Lines = new[] {strArr1[0],strArr1[1],strArr1[2],
                "",strArr2[0],strArr2[1],strArr2[2]};
        }

        private int getValueFromTB(TextBox textBox1)
        {
            return int.Parse(textBox1.Text);
        }
    }
}
