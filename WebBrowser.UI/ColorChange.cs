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

namespace WebBrowser.UI
{
    public partial class ColorChange : UserControl
    {
        bool started = false;
        public ColorChange()
        {
            InitializeComponent();
        }

        

        private void ColorChange_Load(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBoxAddress.Text);

                if (started)
                {
                    this.buttonGo.Text = "Start";
                    timer1.Stop();
                }
                else
                {
                    this.buttonGo.Text = "Stop";
                    this.progressBar1.Value = 0;
                    timer1.Start();
                }
                started = !started;
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxAddress.Text);

            if (started)
            {
                this.buttonGo.Text = "Start";
                timer1.Stop();
            }
            else
            {
                this.buttonGo.Text = "Stop";
                this.progressBar1.Value = 0;
                timer1.Start();
            }
            started = !started;            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void tsForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void tsBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem();
            item.URL = textBoxAddress.Text;
            item.Title = textBoxAddress.Text;

            BookmarkManager.AddItem(item);

            
        }

        private void textBoxAddress_Click(object sender, EventArgs e)
        {
            var item = new HistoryItem();
            item.URL = textBoxAddress.Text;
            item.Title= textBoxAddress.Text;
            item.Date = DateTime.Now;

            HistoryManager.AddItem(item);

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value == 10)
            {
                timer1.Stop();
                this.started = false;
                this.toolStripStatusLabel1.Text = "Done";
            }
            else
            {
                this.progressBar1.Value++;
                this.toolStripStatusLabel1.Text = "Loading";
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
