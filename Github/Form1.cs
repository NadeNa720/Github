using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Width = this.ClientRectangle.Width;
            webBrowser1.Height = this.ClientRectangle.Height - 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressBar.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonFovard_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            foreach (Control contr in this.Controls)
            {
                contr.BackColor = Color.FromArgb(50, 50, 50);
                contr.ForeColor = Color.White;
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(200, 200, 200);
            foreach (Control contr in this.Controls)
            {
                contr.BackColor = Color.FromArgb(200, 200, 200);
                contr.ForeColor = Color.Black;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
