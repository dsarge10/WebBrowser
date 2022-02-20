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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //filters out the other items to display only items searched for
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.Items[i].ToString().Contains(textBox1.Text))
                    listBox2.SetSelected(i, true);
                else
                    listBox2.Items.RemoveAt(i);
            }
        }

        //deletes searched for item
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(i);
            }
        }
    }
}
