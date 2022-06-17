using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form1 : Form
    {
        public int deb;
        int points = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 _Form1;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//deb
        {
        }

        private void button1_Click(object sender, EventArgs e)//mno
        {
            st(3);
            txt.Clear();
            if (deb == 1)
            {
                txt.Text += "\r\n" + $"{a} * {b} = {c}";
            }
            else
            {
                txt.Text += "\r\n" + $"{a} * {b} = ";
            }
        }

        private void button2_Click(object sender, EventArgs e)//plus
        {
            st(1);
            txt.Clear();
            if (deb == 1)
            {
                txt.Text += "\r\n" + $"{a} + {b} = {c}";
            }
            else
            {
                txt.Text += "\r\n" + $"{a} + {b} = ";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            st(2);
            txt.Clear();
            if (deb == 1)
            {
                txt.Text += "\r\n" + $"{a} - {b} = {c}";
            }
            else
            {
                txt.Text += "\r\n" + $"{a} - {b} = ";
            }
        }

        private void dziel_Click(object sender, EventArgs e)
        {
            st(4);
            txt.Clear();
            if (deb == 1)
            {
                txt.Text += "\r\n" + $"{a} / {b} = {c}";
            }
            else
            {
                txt.Text += "\r\n" + $"{a} / {b} = ";
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
        void st(int tto)
        {
            string tt = txt.Text;
            htxt();
            if (erctr == 1)
            {
                erctr = 0;
                c = 0;
            }
            else
            {
                txt.Text += tt;
                int to = Convert.ToInt32(tt);
                txt.Text += to;
                cfg(to, tto);
            }
        }

        private void c_anser_CheckedChanged(object sender, EventArgs e)
        {
            if(c_anser.Checked == true)
            {
                deb = 1;
            }
            else
            {
                deb = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }

        public long a = 0;
        public long b = 0;
        public long c;
        public int err = 0;
        long times = 0;
        Random rand = new Random();

        public void cfg(long to, int ctr)
        { 
            if (ctr == 0)
            {
                while (true)
                {
                    c = a + b;
                    if (c == to)
                    {
                        break;
                    }
                    if (c < to)
                    {
                        int rr = rand.Next(0, 3);
                        if (rr == 1)
                        {
                            a += 1;
                        }
                        if (rr == 2)
                        {
                            b += 1;
                        }

                    }
                }
            }
            if (ctr == 1)
            {
                int too = Convert.ToInt32(to);
                a = rand.Next(0, too);
                b = rand.Next(0, too);
                while (true)
                {
                    c = a + b;

                    if (c < to)
                    {
                        break;
                    }

                    int q = rand.Next(0, 3);
                    if (q == 1)
                    {
                        a -= 1;
                    }
                    if (q == 2)
                    {
                        b -= 1;
                    }

                }
            }
            if (ctr == 2)
            {
                int too = Convert.ToInt32(to);
                a = rand.Next(0, too);
                b = rand.Next(0, too);
                while(true)
                {
                    c = a - b;

                    if(c < to)
                    {
                        break;
                    }

                    int q = rand.Next(0, 3);
                    if (q == 1)
                    {
                        a -= 1;
                    }
                    if (q == 2)
                    {
                        b -= 1;
                    }

                }
            }
            if (ctr == 3)
            {
                int too = Convert.ToInt32(to);
                a = rand.Next(0, too);
                b = rand.Next(0, too);
                while (true)
                {
                    c = a * b;

                    if (c < to)
                    {
                        break;
                    }

                    int q = rand.Next(0, 3);
                    if (q == 1)
                    {
                        a -= 1;
                    }
                    if (q == 2)
                    {
                        b -= 1;
                    }

                }
            }
            if (ctr == 4)
            {
                int too = Convert.ToInt32(to);
                a = rand.Next(0, too);
                b = rand.Next(0, too);
                if(a == 0)
                {
                    a += 1;
                }
                if(b == 0)
                {
                    b += 1;
                }

                c = a / b;
            }
        }

        private void to_Click(object sender, EventArgs e)
        {

        }
        int erctr = 0;
        void hans()
        {
            string tt = ans.Text;
            long yes;
            bool re = Int64.TryParse(tt, out yes);
            if (!re == true)
            {
                txt.Text = "don't type lethers!!!";
                erctr = 1;
            }
        }
        void htxt()
        {
            
            string tt = txt.Text;
            long yes;
            bool re = Int64.TryParse(tt, out yes);
            if (!re == true)
            {
                txt.Text = "don't type lethers!!!";
                erctr = 1;
            }
        }

        private void heck_Click(object sender, EventArgs e)
        {
            hans();
            if(erctr == 1)
            {
            }
            else
            {
                string ccc = ans.Text;
                long cc = Convert.ToInt64(ccc);
                if(c == cc)
                {
                    ans.Text = "Good";
                    points += 1;
                    lab1.Text = $"Points: {points}";
                }
            }
        }
    }
}
