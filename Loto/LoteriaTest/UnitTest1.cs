using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExamenLoto;





namespace LoteriaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
        public void validarNumeroValido()
        {
             lotoLSF2223 miLotoTest;
               int maxNumeros = 6;
            // preparación del caso de prueba
            int[] numerosIntroducidos = new int[maxNumeros];
            numerosIntroducidos[0] = 1;
            numerosIntroducidos[1] = 2;
            numerosIntroducidos[2] = 3;
            numerosIntroducidos[3] = 4;
            numerosIntroducidos[4] = 5;
            numerosIntroducidos[5] = 6;

            bool resultadoEsperado = true;
           
            Examen2EVLSF2223 miApp = new Examen2EVLSF2223();
            // Método a probar
            miLotoTest = new lotoLSF2223(numerosIntroducidos);
        

            Assert.IsTrue(miLotoTest.Ok);

        }

        [TestMethod]

        public void validarNumeroFueraRango()
        {
            lotoLSF2223 miLotoTest;
            int maxNumeros = 6;
            // preparación del caso de prueba
            int[] numerosIntroducidos = new int[maxNumeros];
            numerosIntroducidos[0] = 1;
            numerosIntroducidos[1] = 2;
            numerosIntroducidos[2] = 3;
            numerosIntroducidos[3] = 99;
            numerosIntroducidos[4] = 5;
            numerosIntroducidos[5] = 88;

            bool resultadoEsperado = false;

            Examen2EVLSF2223 miApp = new Examen2EVLSF2223();
            // Método a probar
            miLotoTest = new lotoLSF2223(numerosIntroducidos);

            //Assert.AreEqual(miLotoTest, miApp.miLoto,
           //  resultadoEsperado, "Combinación no válida");

            Assert.IsFalse(miLotoTest.Ok);

        }

        [TestMethod]
        public void validarValoresNoNumericos()
        {
            lotoLSF2223 miLotoTest;
            int maxNumeros = 6;
            // preparación del caso de prueba
            int[] numerosIntroducidos = new int[maxNumeros];
            numerosIntroducidos[0] = 1;
            numerosIntroducidos[1] = 2;
            numerosIntroducidos[2] = 'o';
            numerosIntroducidos[3] = 99;
            numerosIntroducidos[4] = 5;
            numerosIntroducidos[5] = 88;

            bool resultadoEsperado = false;

            Examen2EVLSF2223 miApp = new Examen2EVLSF2223();
            // Método a probar
            miLotoTest = new lotoLSF2223(numerosIntroducidos);

            //Assert.AreEqual(miLotoTest, miApp.miLoto,
            //  resultadoEsperado, "Combinación no válida");

            Assert.IsFalse(miLotoTest.Ok);

        }


        [TestMethod]
        public void validarNumerosNegativos()
        {
            lotoLSF2223 miLotoTest;
            int maxNumeros = 6;
            // preparación del caso de prueba
            int[] numerosIntroducidos = new int[maxNumeros];
           
            numerosIntroducidos[1] = 2;
            numerosIntroducidos[2] = 30;
            numerosIntroducidos[3] = 99;
            numerosIntroducidos[4] = 5;
            numerosIntroducidos[5] = 88;

            bool resultadoEsperado = true;

            Examen2EVLSF2223 miApp = new Examen2EVLSF2223();
            // Método a probar
            miLotoTest = new lotoLSF2223(numerosIntroducidos);

            //Assert.AreEqual(miLotoTest, miApp.miLoto,
            //  resultadoEsperado, "Combinación no válida");

            Assert.IsFalse(miLotoTest.Ok);

        }


        [TestMethod]
        public void validarValoresNull()
        {
            lotoLSF2223 miLotoTest;
            int maxNumeros = 6;
            // preparación del caso de prueba
            int[] numerosIntroducidos = new int[maxNumeros];
            numerosIntroducidos[0] = -1;
            numerosIntroducidos[1] = -2;
            numerosIntroducidos[2] = -7;
            numerosIntroducidos[3] = -99;
            numerosIntroducidos[4] = -5;
            numerosIntroducidos[5] = -88;

            bool resultadoEsperado = false;

            Examen2EVLSF2223 miApp = new Examen2EVLSF2223();
            // Método a probar
            miLotoTest = new lotoLSF2223(numerosIntroducidos);

            //Assert.AreEqual(miLotoTest, miApp.miLoto,
            //  resultadoEsperado, "Combinación no válida");

            Assert.IsFalse(miLotoTest.Ok);

        }
    }
}
