using Entidades;
namespace MyUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void LogearUsuarioValido()
        {

            //AA

            //ARANGE - GIVEN 
            //usuario y contrase�a existente
            Usuario usuario;
            string user = "a@a";
            string contrase�a = "1234";

            //ACT -WHEN
            //intentar logearme
            usuario = ArchivoUsuarios.LogearUsuario(user, contrase�a);


            Assert.IsNotNull(usuario);
            Assert.AreEqual(usuario.Correo, user);

            //ASERT - THEN 
        }

    }
}



