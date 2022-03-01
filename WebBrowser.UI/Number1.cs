using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Drawing.Printing;
using System.IO;




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


        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForm = new Number2();
            itemsForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForms = new Number3();
            itemsForms.ShowDialog();
        }

        private void colorChange5_Load(object sender, EventArgs e)
        {
            var itemsForm = new Number2();
            itemsForm.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        //private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    var lastIndex = this.tabControl1.TabCount - 1;
        //    if (this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
        //    {
        //        this.tabControl1.TabPages.Insert(lastIndex, "New Tab");
        //        this.tabControl1.SelectedIndex = lastIndex;


        //        this.Dock = DockStyle.Fill;
        //        this.Controls.Add(this.tabControl1);

        //    }
        //}

        //private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        //{
        //    if (e.TabPageIndex == this.tabControl1.TabCount - 1)
        //        e.Cancel = true;
        //}
        //[DllImport("user32.dll")]
        //private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        //private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        //private void tabControl1_HandleCreated(object sender, EventArgs e)
        //{
        //    SendMessage(this.tabControl1.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        //}



       




        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Number1_Load(object sender, EventArgs e)
        {

        }



        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                reviewsPrintDialog.Document = reviewsPrintDocument.Document;
                DialogResult result = reviewsPrintDialog.ShowDialog();  
                if ( result == DialogResult.OK )
                {
                    //MessageBox.Show("Printer Name: " + reviewsPrintDialog.PrinterSettings.PrinterName + "\r\n" + "Copies: " + reviewsPrintDocument.PrinterSettings.Copies);
                    //reviewsPrintDocument.Document();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
