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
    public partial class RestauranteMan2 : Form
    {
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();
        ProxyRestaurante.RestauranteBE objRestaurante = new ProxyRestaurante.RestauranteBE();

        public RestauranteMan2()
        {
            InitializeComponent();
        }

        private Int16 _Codigo;

        public Int16 Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void RestauranteMan2_Load(object sender, EventArgs e)
        {
            objRestaurante = srvRestaurantes.GetRestaurante(this.Codigo);

            txtNombre.Text = objRestaurante.Nom_Restaurante;
            txtDireccion.Text = objRestaurante.Direc_Restaurante;
            txtTelefono.Text = objRestaurante.Tele_Restaurante;
            CargarCategoria(objRestaurante.Cate_Restaurante);
            CargarDistrito(objRestaurante.Distri_Restaurante);
            chkEstado.Checked = Convert.ToBoolean(objRestaurante.Estado_Restaurante);
        }

        private void CargarCategoria(Int16 idCate)
        {
            cboCategoria.DataSource = srvRestaurantes.GetAllCategorias();
            cboCategoria.ValueMember = "Cate_Restaurante";
            cboCategoria.DisplayMember = "Nom_CategoriaRestaurante";
            cboCategoria.SelectedValue = idCate;
        }

        private void CargarDistrito(Int16 idDistri)
        {
            cboDistrito.DataSource = srvRestaurantes.GetAllDistritos();
            cboDistrito.ValueMember = "Distri_Restaurante";
            cboDistrito.DisplayMember = "Nom_DistritoRestaurante";
            cboDistrito.SelectedValue = idDistri;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == String.Empty)
            {
                throw new Exception("El nombre es obligatorio");
            }

            if (txtDireccion.Text.Trim() == String.Empty)
            {
                throw new Exception("La dirección es obligatoria");
            }

            if (txtTelefono.Text.Trim() == String.Empty)
            {
                throw new Exception("El teléfono es obligatorio");
            }

            objRestaurante.Id_Restaurante = this.Codigo;
            objRestaurante.Nom_Restaurante = txtNombre.Text.Trim();
            objRestaurante.Direc_Restaurante = txtDireccion.Text.Trim();
            objRestaurante.Tele_Restaurante = txtTelefono.Text.Trim();
            objRestaurante.Cate_Restaurante = Convert.ToInt16(cboCategoria.SelectedValue);
            objRestaurante.Distri_Restaurante = Convert.ToInt16(cboDistrito.SelectedValue);
            objRestaurante.UsuUltModi_Restaurante = clsCredenciales.Usuario;
            objRestaurante.Estado_Restaurante = Convert.ToInt16(chkEstado.Checked);

            if (srvRestaurantes.UpdateRestaurante(objRestaurante) == true)
            {
                this.Close();
            }
            else
            {
                throw new Exception("No se pudo actualizar el registro");
            }
        }
    }
}
