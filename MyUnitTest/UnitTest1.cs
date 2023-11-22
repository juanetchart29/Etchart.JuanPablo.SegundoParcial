using Entidades;
namespace MyUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [DataRow("a@a","1234")]
        [DataRow("a@a","1233")]
        [TestMethod]
        public void LogearUsuarioValido(string user, string contraseņa)
        {

            //AA

            //ARANGE - GIVEN 
            //usuario y contraseņa existente
            Usuario usuario;

            //ACT -WHEN
            //intentar logearme
            usuario = ArchivoUsuarios.LogearUsuario(user, contraseņa);


            Assert.IsNotNull(usuario);
            Assert.AreEqual(usuario.Correo, user);
            Assert.AreEqual(usuario.Clave, contraseņa);
            //ASERT - THEN 
        }

    }
}



