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
    public partial class Number3 : Form
    {
        public Number3()
        {
            InitializeComponent();
        }

        private void Number3_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox2.Items.Clear();

            foreach (var item in items)
            {
                listBox2.Items.Add(string.Format("{0} - {1}", item.Title, item.URL));
            }
        }
    }
}
