using System;
using System.Windows.Forms;
using BuenosAires.Model.Utiles;
using BuenosAires.ServiceProxy;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var sc = new ScAutenticacion();
            sc.Autenticar("Bodeguero", txtCuenta.Text, txtPassword.Text);
            if (sc.Autenticado)
            {
                new VentanaProducto(sc.NombreUsuario + " (" + sc.TipoUsuario + ")").Show();
                Hide();
            }
            else
            {
                this.MensajeInfo(sc.Mensaje);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
