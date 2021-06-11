using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConversorNumerosRomanos.Consoleapp;

namespace TransformandoNumeroemRomanosTest
{
    [TestClass]
    public class NumerosRomanosTests

    {
      
        [TestMethod]
        public void DeveRetorna1()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("I");
            Assert.AreEqual("1", resultado);
        }
        [TestMethod]
        public void DeveRetorna2()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("II");
            Assert.AreEqual("2", resultado);
        }

        [TestMethod]
        public void DeveRetorna3()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("III");
            Assert.AreEqual("3", resultado);
        }
        [TestMethod]
        public void DeveRetorna5()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("V");
            Assert.AreEqual("5", resultado);
        }
        [TestMethod]
        public void DeveRetorna10()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("X");
            Assert.AreEqual("10", resultado);
        }
        [TestMethod]
        public void DeveRetorna50()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("L");
            Assert.AreEqual("50", resultado);
        }

        [TestMethod]
        public void DeveRetorna100()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("C");
            Assert.AreEqual("100", resultado);
        }
        [TestMethod]
        public void DeveRetorna500()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("D");
            Assert.AreEqual("500", resultado);
        }
        [TestMethod]
        public void DeveRetorna1000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("M");
            Assert.AreEqual("1000", resultado);
        }
        [TestMethod]
        public void DeveRetorna4()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("IV");
            Assert.AreEqual("4", resultado);
        }
        [TestMethod]
        public void DeveRetorna30()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("XXX");
            Assert.AreEqual("30", resultado);
        }
        [TestMethod]
        public void DeveRetorna52()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("LII");
            Assert.AreEqual("52", resultado);
        }
        [TestMethod]
        public void DeveRetorna137()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("CXXXVII");
            Assert.AreEqual("137", resultado);
        }
        [TestMethod]
        public void DeveRetorna200()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("CC");
            Assert.AreEqual("200", resultado);
        }
        [TestMethod]
        public void DeveRetorna361()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("CCCLXI");
            Assert.AreEqual("361", resultado);
        }
        [TestMethod]
        public void DeveRetorna444()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("CDXLIV");
            Assert.AreEqual("444", resultado);
        }
        [TestMethod]
        public void DeveRetorna589()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("DLXXXIX");
            Assert.AreEqual("589", resultado);
        }
        [TestMethod]
        public void DeveRetorna637()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("DCXXXVII");
            Assert.AreEqual("637", resultado);
        }
        [TestMethod]
        public void DeveRetorna1886()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("MDCCCLXXXVI");
            Assert.AreEqual("1886", resultado);
        }
        [TestMethod]
        public void DeveRetorna2459()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("MMCDLIX");
            Assert.AreEqual("2459", resultado);
        }
        [TestMethod]
        public void DeveRetorna3562()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("MMMDLXII");
            Assert.AreEqual("3562", resultado);
        }
        [TestMethod]
        public void DeveRetorna3999()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            string resultado = numerosRomanos.ConverteParaDecimal("MMMCMXCIX");
            Assert.AreEqual("3999", resultado);
        }
   
        #region TESTE ACIMA DE 4 MIL
        [TestMethod]
        public void DeveRetorna4000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("R");
            Assert.AreEqual("4000", resultado);
        }

        [TestMethod]
        public void DeveRetorna5000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("S");
            Assert.AreEqual("5000", resultado);
        }
        [TestMethod]
        public void DeveRetorna6000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("T");
            Assert.AreEqual("6000", resultado);
        }
        [TestMethod]
        public void DeveRetorna7000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("U");
            Assert.AreEqual("7000", resultado);
        }
        [TestMethod]
        public void DeveRetorna8000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("F");
            Assert.AreEqual("8000", resultado);
        }
        [TestMethod]
        public void DeveRetorna9000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("G");
            Assert.AreEqual("9000", resultado);
        }
        [TestMethod]
        public void DeveRetorna10000()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("B");
            Assert.AreEqual("10000", resultado);
        }
        [TestMethod]
        public void DeveRetorna4001()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("RI");
            Assert.AreEqual("4001", resultado);
        }
        [TestMethod]
        public void DeveRetorna5005()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("SV");
            Assert.AreEqual("5005", resultado);
        }
        [TestMethod]
        public void DeveRetorna5055()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("SLV");
            Assert.AreEqual("5055", resultado);
        }
        [TestMethod]
        public void DeveRetorna6100()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("TC");
            Assert.AreEqual("6100", resultado);
        }
        [TestMethod]
        public void DeveRetorna7521()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("UDXXI");
            Assert.AreEqual("7521", resultado);
        }
        [TestMethod]
        public void DeveRetorna8844()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("FDCCCXXXVIIIVI");
            Assert.AreEqual("8844", resultado);
        }
        [TestMethod]
        public void DeveRetorna9940()
        {
            ConverteNumerosRomanos numerosRomanos = new ConverteNumerosRomanos();
            String resultado = numerosRomanos.ConverterMais4Mil("GDCCCLLXXXVV");
            Assert.AreEqual("9940", resultado);
        }
        #endregion

    }
}
