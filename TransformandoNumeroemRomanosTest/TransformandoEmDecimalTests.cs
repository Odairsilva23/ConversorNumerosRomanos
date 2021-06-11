using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConversorNumerosRomanos.Consoleapp;

namespace TransformandoNumeroemRomanosTest
{
    [TestClass]
    public class NumerosDecimalTests

    {

        [TestMethod]
        public void DeveRetorna1()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("1");
            Assert.AreEqual("I", resultado);
        }
        [TestMethod]
        public void DeveRetorna2()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("2");
            Assert.AreEqual("II", resultado);
        }
        [TestMethod]
        public void DeveRetorna3()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("3");
            Assert.AreEqual("III", resultado);
        }
        [TestMethod]
        public void DeveRetorna4()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("4");
            Assert.AreEqual("IV", resultado);
        }
        [TestMethod]
        public void DeveRetorna5()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("5");
            Assert.AreEqual("V", resultado);
        }
        [TestMethod]
        public void DeveRetorna6()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("6");
            Assert.AreEqual("VI", resultado);
        }
        [TestMethod]
        public void DeveRetorna7()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("7");
            Assert.AreEqual("VII", resultado);
        }
        [TestMethod]
        public void DeveRetorna8()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("8");
            Assert.AreEqual("VIII", resultado);
        }
        [TestMethod]
        public void DeveRetorna9()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("9");
            Assert.AreEqual("IX", resultado);
        }
        [TestMethod]
        public void DeveRetorna10()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("10");
            Assert.AreEqual("X", resultado);
        }
        [TestMethod]
        public void DeveRetorna11()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("11");
            Assert.AreEqual("XI", resultado);
        }
        [TestMethod]
        public void DeveRetorna19()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("19");
            Assert.AreEqual("XIX", resultado);
        }
        [TestMethod]
        public void DeveRetorna40()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("40");
            Assert.AreEqual("XL", resultado);
        }
        [TestMethod]
        public void DeveRetorna1000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("1000");
            Assert.AreEqual("M", resultado);
        }
        [TestMethod]
        public void DeveRetorna12()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("12");
            Assert.AreEqual("XII", resultado);
        }
        [TestMethod]
        public void DeveRetorna13()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("13");
            Assert.AreEqual("XIII", resultado);
        }
        [TestMethod]
        public void DeveRetorna14()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("14");
            Assert.AreEqual("XIV", resultado);
        }
        [TestMethod]
        public void DeveRetorna15()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("15");
            Assert.AreEqual("XV", resultado);
        }
        [TestMethod]
        public void DeveRetorna1995()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("1995");
            Assert.AreEqual("MCMXCV", resultado);
        }
        [TestMethod]
        public void DeveRetorna2050()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("2050");
            Assert.AreEqual("MML", resultado);
        }
        [TestMethod]
        public void DeveRetorna2116()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("2116");
            Assert.AreEqual("MMCXVI", resultado);
        }
        [TestMethod]
        public void DeveRetorna3252()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("3252");
            Assert.AreEqual("MMMCCLII", resultado);
        }
        [TestMethod]
        public void DeveRetorna3999()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("3999");
            Assert.AreEqual("MMMCMXCIX", resultado);
        }

        #region Acima de 4 Mil
        [TestMethod]
        public void DeveRetorna4000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("4000");
            Assert.AreEqual("ĪV̄", resultado);
        }
        [TestMethod]
        public void DeveRetorna5000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("5000");
            Assert.AreEqual("V̄", resultado);
        }
        [TestMethod]
        public void DeveRetorna6000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("6000");
            Assert.AreEqual("V̄Ī", resultado);
        }
        [TestMethod]
        public void DeveRetorna7000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("7000");
            Assert.AreEqual("V̄ĪĪ", resultado);
        }
        [TestMethod]
        public void DeveRetorna8000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("8000");
            Assert.AreEqual("V̄ĪĪĪ", resultado);
        }
        [TestMethod]
        public void DeveRetorna9000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("9000");
            Assert.AreEqual("ĪX̄", resultado);
        }
        [TestMethod]
        public void DeveRetorna10000()
        {
            NumerosArabicos numerosRomanos = new NumerosArabicos();
            string resultado = numerosRomanos.ConverterParaRomano("10000");
            Assert.AreEqual("X̄", resultado);
        }
        #endregion
    }
}
