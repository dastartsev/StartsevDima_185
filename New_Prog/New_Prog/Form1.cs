using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Prog
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = this.label1.Text;
            int v = int.Parse(txt);
            label1.Text = (++v).ToString();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            string txt = this.label1.Text;
            int v = int.Parse(txt);
            label1.Text = (--v).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            Color c = Color.FromArgb(r,g,b);

            uint x = 0xFF000000 + (uint)rnd.Next(256 * 256 * 256);

            Color c_0 = Color.FromArgb((int)x);

            BackColor = c_0;
            timer1.Enabled = true;

        }
        
        int x, y, xC, yC;

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

        }

           // Label1.Text = (v).ToString;

        private void timer1_Tick(object sender, EventArgs e)
        {
            uint x = 0xFF000000 + (uint)rnd.Next(256 * 256 * 256);

            Color c_0 = Color.FromArgb((int)x);

            BackColor = c_0;

            string txt = this.label1.Text;
            int v = int.Parse(txt);
            label1.Text = (++v).ToString();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            int dx = e.X - xC;
            int dy = e.Y - yC;
            button.Location = new Point(x + dx, y + dy);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            x = button.Location.X;
            y = button.Location.Y;
            xC = e.X;
            yC = e.Y;
        }
    }
}
