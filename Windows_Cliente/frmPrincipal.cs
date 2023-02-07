using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Cliente
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void restaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestauranteMan1 rest1 = new RestauranteMan1();
            rest1.MdiParent = this;
            rest1.Show();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcel excel = new frmExcel();
            excel.MdiParent = this;
            excel.Show();
        }
    }
}
