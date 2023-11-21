
using Entidades;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.usuarios = ArchivoUsuarios.TraerUsuarios();
            this.correo = txtboxEmail.Text;
            this.contraseña = txtBoxContraseña.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese correo y contraseña.");
                return;
            }


            foreach (Usuario item in this.usuarios)
            {

                if (this.contraseña == item.Clave && this.correo == item.Correo)
                {
                    this.usuarioActual = item;
                    ArchivoUsuarios.Registrar(this.usuarioActual);
                    LanzarForm();

                    break;
                }
            }
            if (this.usuarioActual == null)
            {
                MessageBox.Show("Correo o contraseña incorrectos.");// si llega hasta aca es que no se logeo

            }
            else { this.Close(); }
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

            if (principal.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
