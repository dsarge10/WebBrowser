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
    public partial class Number2 : Form
    {
        public Number2()
        {
            InitializeComponent();
        }

        private void Number2_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

           foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("{0} - {1} - {2}", item.URL, item.Title, item.Date));
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
