using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebBrowser.UI
{
    public partial class Number1 : Form
    {
        public Number1()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dylan Sargent, dds0037, This is my first Web Application.");
        }

        private void Number1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
                this.tabControl1.TabPages.Add(new TabPage("New Tab"));
                this.Dock = DockStyle.Fill;
                this.Controls.Add(this.tabControl1);
                
                

            if (e.Control && (e.KeyCode == Keys.W))
                this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage myTabPages = new TabPage("New Tab");
            myTabPages.Dock = DockStyle.Fill;
            myTabPages.Controls.Add(colorChange4);
            tabControl1.TabPages.Add(myTabPages);
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //Number1 myUserControl = new Number1();
            //myUserControl.Dock = DockStyle.Fill;
            //TabPage myTabPage = new TabPage();//Create new tabpage
            //myTabPage.Controls.Add(myUserControl);
            //tabControl1.TabPages.Add(myTabPage);
        }



        //private void keyDown(object sender, KeyEventArgs e)
        //{
        ////    if (e.KeyCode == Keys.Enter)
        ////    {
        ////        webBrowser1.Navigate(textBoxAddress.Text);
        ////    }
        //}

        //private void toolStripTextBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void buttonGo_Click(object sender, EventArgs e)
        //{
        //    //webBrowser1.Navigate(textBoxAddress.Text);  
        //}


    }
}
