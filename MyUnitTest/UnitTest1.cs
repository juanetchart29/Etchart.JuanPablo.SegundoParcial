using Entidades;
namespace MyUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [DataRow("a@a","1234")]
        [DataRow("a@a","1233")]
        [TestMethod]
        public void LogearUsuarioValido(string user, string contraseña)
        {

            //AA

            //ARANGE - GIVEN 
            //usuario y contraseña existente
            Usuario usuario;

            //ACT -WHEN
            //intentar logearme
            usuario = ArchivoUsuarios.LogearUsuario(user, contraseña);


            Assert.IsNotNull(usuario);
            Assert.AreEqual(usuario.Correo, user);

            //ASERT - THEN 
        }

    }
}



