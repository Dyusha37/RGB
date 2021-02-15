using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : Form
    {
        int r, g, b;
        public Form1()
        {
            InitializeComponent();
            r = this.BackColor.R;
            g = this.BackColor.G;
            b = this.BackColor.B;

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            g = this.BackColor.G;
            b = this.BackColor.B;
            this.BackColor = Color.FromArgb(vScrollBar1.Value, g, b);
            label1.Text = Convert.ToString(vScrollBar1.Value);
        }

        private void VScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            r = this.BackColor.R;
            b = this.BackColor.B;
            this.BackColor = Color.FromArgb(r, vScrollBar2.Value, b);
            label2.Text = Convert.ToString(vScrollBar2.Value);
        }

        private void VScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            r = this.BackColor.R;
            g = this.BackColor.G;
            this.BackColor = Color.FromArgb(r, g, vScrollBar3.Value);
            label3.Text = Convert.ToString(vScrollBar3.Value);
        }
    }
}
