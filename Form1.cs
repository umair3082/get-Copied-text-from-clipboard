using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace copy_past_clipboard
{
    public partial class Form1 : Form
    {
        System.Timers.Timer tm;
        public Form1()
        {
            InitializeComponent();
            tm = new System.Timers.Timer(100);
            tm.Elapsed += TimerElapsed;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "A951234";
            //label1.Text = "9586vnb";
            if (label1.Text.Trim().StartsWith("A5"))
            {
                MessageBox.Show("Start With A95");
            Clipboard.SetText("Hello Umair Pasted Text"+" "+label1.Text);
            label2.Text = Clipboard.GetText();

            }
           // tm.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //tm.Enabled = false;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (true)
            {
                
                if (label1.Text.Trim().StartsWith("A95"))
                {
                    Clipboard.SetText("Hello Umair Pasted Text" + " " + label1.Text);
                    label2.Text = Clipboard.GetText();

                }
                else
                {
                    MessageBox.Show("Not contain 95\r\r"+ Clipboard.GetText());
                }
                Thread.Sleep(1000);
            }
        }
    }
}
