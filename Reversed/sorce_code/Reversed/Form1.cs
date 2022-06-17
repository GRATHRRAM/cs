using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brev_Click(object sender, EventArgs e)
        {
            string t = t1.Text;
            if(t == "")
            {
                t1.Text = "What??";
            }
            else
            {
                string ctr = t.Substring(0, 1);
                if (ctr == " ")
                {
                    t1.Text = "Not start with space!!!";
                }
            }

            t1.Clear();
            t2.Clear();

            if (t == "")
            {
                t1.Text = "Type some thig!!!";
            }
    
            else
            {
                string revString = "";
                t = t.ToLower();
                for (int i = t.Length - 1; i >= 0; i--)
                {
                    revString = revString + t[i];
                }
                t2.Text = revString;
            }
        }
    }
}
