using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_mySQL
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecetas frmrecetas = new frmrecetas();
            frmrecetas.MdiParent = this;
            frmrecetas.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtest frmtest = new frmtest();
            frmtest.Show();
        }
    }
}
