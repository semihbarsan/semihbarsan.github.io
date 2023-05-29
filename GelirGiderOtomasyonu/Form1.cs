using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GelirGiderOtomasyonu
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
            InitializeComponent();

            // Form boyutunu sabitle
            this.MinimumSize = new Size(1200, 600);
            this.MaximumSize = new Size(1200, 600);

          
        }

        private void malzemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var malzeme = new Malzemeler
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false,
            };

            malzeme.StartPosition = FormStartPosition.CenterParent;
            malzeme.ShowDialog(this);
        }
        private void yardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var yardim = new yardim
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false,
            };

            yardim.StartPosition = FormStartPosition.CenterParent;
            yardim.ShowDialog(this);
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var gider = new Giderler
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false,
            };

            gider.StartPosition = FormStartPosition.CenterParent;
            gider.ShowDialog(this);
        }

        private void gelirlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gider = new Gelirler
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false,
            };

            gider.StartPosition = FormStartPosition.CenterParent;
            gider.ShowDialog(this);
        }
    }
}
