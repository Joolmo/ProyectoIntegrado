using Microsoft.VisualStudio.TestTools.UnitTesting;
using primeraprueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraprueba.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void LogInTest()
        {
            Assert.IsTrue(Usuario.LogIn("ruben", "ruben"));
        }

        [TestMethod()]
        public void GetRecetaTest()
        {
            Assert.AreEqual(Receta.GetReceta(42).IdUsuario, 39);
        }

        [TestMethod()]
        public void GetUsuarioTest()
        {
            Assert.AreEqual(Usuario.GetUsuario(41).Nombre, "jaboca");
        }


    }
}