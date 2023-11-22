using Entidades;
namespace MyUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void LogearUsuario_UsuarioExistente_DevuelveUsuario()
        {
            // Arrange
            string correo = "a@a";
            string contraseña = "1234";
            Usuario usuario;

            // Act
            usuario = ArchivoUsuarios.LogearUsuario(correo, contraseña);

            // Assert
            Assert.IsNotNull(usuario);
            Assert.AreEqual(correo, usuario.Correo);
            Assert.AreEqual(contraseña, usuario.Clave);
        }

        [TestMethod]
        public void LogearUsuario_UsuarioNoExistente_DevuelveNull()
        {
            // Arrange
            string correo = "a@a";
            string contraseña = "1233";
            Usuario usuario;

            // Act
            usuario = ArchivoUsuarios.LogearUsuario(correo, contraseña);

            // Assert
            Assert.IsNull(usuario);
        }
    }
}



