using NUnit.Framework;

namespace UnitTestUsuarios
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void LogearUsuarioValido()
        {

            //AA

            //ARANGE - GIVEN 
            //usuario y contraseña existente
            Usuario usuario;
            string user = "a@a";
            string contraseña = "1234";

            //ACT -WHEN
            //intentar logearme
            usuario = ArchivoUsuarios.LogearUsuario(user, contraseña);


            Assert.IsNotNull(usuario);
            Assert.AreEqual(usuario.Correo, user);

            //ASERT - THEN 
        }
    }