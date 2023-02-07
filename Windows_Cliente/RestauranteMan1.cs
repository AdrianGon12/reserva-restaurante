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
    public partial class RestauranteMan1 : Form
    {
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();

        public RestauranteMan1()
        {
            InitializeComponent();
        }

        private void RestauranteMan1_Load(object sender, EventArgs e)
        {
            dtgRestaurantes.AutoGenerateColumns = false;
            dtgRestaurantes.DataSource = srvRestaurantes.GetAllRestaurantes();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            RestauranteMan3 rest3 = new RestauranteMan3();
            rest3.ShowDialog();

            dtgRestaurantes.DataSource = srvRestaurantes.GetAllRestaurantes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RestauranteMan2 rest2 = new RestauranteMan2();
            rest2.Codigo = Convert.ToInt16(dtgRestaurantes.CurrentRow.Cells[0].Value);
            rest2.ShowDialog();

            dtgRestaurantes.DataSource = srvRestaurantes.GetAllRestaurantes();
        }

        private void dtgRestaurantes_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
