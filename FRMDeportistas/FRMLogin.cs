
using Entidades;
using Microsoft.Data.SqlClient;

namespace FRMDeportistas
{
    public partial class FRMLogin : Form
    {
        public string correo;
        public string contraseña;
        public Usuario usuarioActual = null;
        public List<Usuario>? usuarios;


        public FRMLogin()
        {
            InitializeComponent();
            this.usuarios = ArchivoUsuarios.TraerUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.correo = txtboxEmail.Text;
            this.contraseña = txtBoxContraseña.Text;

            this.usuarioActual = this.UsuarioCorrecto();
            if (this.usuarioActual is null)
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }
            else 
                LanzarForm();
        }


        private bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public Usuario UsuarioCorrecto()
        {
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña) || !EmailValido(correo))
            {
                return null;
            }


            foreach (Usuario item in this.usuarios)
            {

                if (this.contraseña == item.Clave && this.correo == item.Correo)
                {
                    this.usuarioActual = item;
                    ArchivoUsuarios.Registrar(this.usuarioActual);
                    return item;
                }
            }
            return null;
        }


        private void checkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkContraseña.Checked)
            {
                txtBoxContraseña.PasswordChar = '\0'; //me muestra la contraseña normal
            }
            else
            {
                txtBoxContraseña.PasswordChar = '*'; // cubro la contraseña con asteriscos
            }

        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            this.txtBoxContraseña.PasswordChar = '*';

        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // cuando veamos sql lo hago en una base de datos
        }


        private void LanzarForm()
        {

            FRMMenuPrincipal principal = new FRMMenuPrincipal(this.usuarioActual);
            this.Hide();
            principal.ShowDialog();

            if (principal.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
