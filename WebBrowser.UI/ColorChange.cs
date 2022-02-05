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
    public partial class ColorChange : UserControl
    {
        public ColorChange()
        {
            InitializeComponent();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            int redValue = tbRed.Value;
            int greenValue = tbGreen.Value;
            int blueValue = tbBlue.Value;   

            try
            {
                pnlColor.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ColorChange_Load(object sender, EventArgs e)
        {

        }
    }
}
