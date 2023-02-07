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
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        ProxyUsuario.ServicioUsuariosClient srvUsuarios = new ProxyUsuario.ServicioUsuariosClient();
        ProxyUsuario.UsuarioBE objUsuario = new ProxyUsuario.UsuarioBE();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() != "" & txtContra.Text.Trim() != "")
            {
                objUsuario = srvUsuarios.GetUsuario(txtCorreo.Text);

                if (objUsuario == null)
                {
                    MessageBox.Show("Usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos(intentos);
                }

                if (txtCorreo.Text == objUsuario.Correo_Usuario & txtContra.Text == objUsuario.Contra_Usuario)
                {
                    if (objUsuario.Nivel_Usuario == 2)
                    {
                        this.Hide();
                        clsCredenciales.Usuario = objUsuario.Correo_Usuario;
                        clsCredenciales.Contra = objUsuario.Contra_Usuario;
                        clsCredenciales.Nivel = objUsuario.Nivel_Usuario;
                        clsCredenciales.IdUsuario = objUsuario.Id_Usuario;
                        frmPrincipal mdi = new frmPrincipal();
                        mdi.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No tiene permisos para ingresar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos(intentos);
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos(intentos);
            }
        }

        private void ValidaAccesos(Int16 intIntentos)
        {
            if (intIntentos == 3)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el numero de intentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
