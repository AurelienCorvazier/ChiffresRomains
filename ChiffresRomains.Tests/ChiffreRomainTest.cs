using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChiffresRomains;
using System;

namespace ChiffresRomains.Tests
{
    [TestClass]
    public class ChiffreRomainTest
    {
        [TestMethod]
        public void I_donne_1()
        { 
            var chiffreRomain = new ChiffreRomain("I");
            Assert.AreEqual(1, chiffreRomain.Entier);
        }

        [TestMethod]
        public void II_donne_2()
        {
            var chiffreRomain = new ChiffreRomain("II");
            Assert.AreEqual(2, chiffreRomain.Entier);
        }

        [TestMethod]
        public void III_donne_3()
        {
            var chiffreRomain = new ChiffreRomain("III");
            Assert.AreEqual(3, chiffreRomain.Entier);
        }

        [TestMethod]
        public void IV_donne_4()
        {
            var chiffreRomain = new ChiffreRomain("IV");
            Assert.AreEqual(4, chiffreRomain.Entier);
        }

        [TestMethod]
        public void X_donne_10()
        {
            var chiffreRomain = new ChiffreRomain("X");
            Assert.AreEqual(10, chiffreRomain.Entier);
        }

        [TestMethod] 
        public void XX_donne_20()
        { 
            var chiffreRomain = new ChiffreRomain("XX");
            Assert.AreEqual(20, chiffreRomain.Entier);
        }

        [TestMethod]
        public void XXX_donne_30()
        {
            var chiffreRomain = new ChiffreRomain("XXX");
            Assert.AreEqual(30, chiffreRomain.Entier);
        }

        [TestMethod]
        public void V_donne_5()
        {
            var chiffreRomain = new ChiffreRomain("V");
            Assert.AreEqual(5, chiffreRomain.Entier);
        }

        [TestMethod]
        public void L_donne_50()
        {
            var chiffreRomain = new ChiffreRomain("L");
            Assert.AreEqual(50, chiffreRomain.Entier);
        }

        [TestMethod]
        public void C_donne_100()
        {
            var chiffreRomain = new ChiffreRomain("C");
            Assert.AreEqual(100, chiffreRomain.Entier);
        }

        [TestMethod]
        public void D_donne_500()
        {
            var chiffreRomain = new ChiffreRomain("D");
            Assert.AreEqual(500, chiffreRomain.Entier);
        }

        [TestMethod]
        public void M_donne_1000()
        {
            var chiffreRomain = new ChiffreRomain("M");
            Assert.AreEqual(1000, chiffreRomain.Entier);
        }

        [TestMethod]
        public void XI_donne_11()
        {
            var chiffreRomain = new ChiffreRomain("XI");
            Assert.AreEqual(11, chiffreRomain.Entier);
        }

        [TestMethod]
        public void XIII_donne_13()
        {
            var chiffreRomain = new ChiffreRomain("XIII");
            Assert.AreEqual(13, chiffreRomain.Entier);
        }

        [TestMethod]
        public void XIII_donne_14()
        {
            var chiffreRomain = new ChiffreRomain("XIV");
            Assert.AreEqual(14, chiffreRomain.Entier);
        }

        [TestMethod]
        public void DIX_donne_509()
        {
            var chiffreRomain = new ChiffreRomain("DIX");
            Assert.AreEqual(509, chiffreRomain.Entier);
        } 

        [TestMethod]
        public void DCLXVI_donne_666()
        {
            var chiffreRomain = new ChiffreRomain("DCLXVI");
            Assert.AreEqual(666, chiffreRomain.Entier);
        }

        [TestMethod]
        public void MDXV_donne_1515()
        {
            var chiffreRomain = new ChiffreRomain("MDXV");
            Assert.AreEqual(1515, chiffreRomain.Entier);
        }

        [TestMethod]
        public void MMMMDCCCLXXXVIII_donne_4888()
        {
            var chiffreRomain = new ChiffreRomain("MMMMDCCCLXXXVIII");
            Assert.AreEqual(4888, chiffreRomain.Entier);
        }

        [TestMethod]
        public void MMXXDD_donne_4888()
        {
            var chiffreRomain = new ChiffreRomain("MMXXDD");
            Assert.AreEqual(2980, chiffreRomain.Entier);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Z n'est pas un caractère romain")]
        public void Z_est_pas_un_caractere_romain()
        {
            new ChiffreRomain("Z");
        }
    }
}
