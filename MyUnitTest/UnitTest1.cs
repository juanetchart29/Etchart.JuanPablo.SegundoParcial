using Entidades;
namespace MyUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [DataRow("a@a","1234")]
        [DataRow("a@a","1233")]
        [TestMethod]
        public void LogearUsuarioValido(string user, string contrase�a)
        {

            //AA

            //ARANGE - GIVEN 
            //usuario y contrase�a existente
            Usuario usuario;

            //ACT -WHEN
            //intentar logearme
            usuario = ArchivoUsuarios.LogearUsuario(user, contrase�a);


            Assert.IsNotNull(usuario);
            Assert.AreEqual(usuario.Correo, user);

            //ASERT - THEN 
        }

    }
}



