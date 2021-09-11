using NUnit.Framework;
using MathHelper;
using System.Collections.Generic;
using System;

namespace NUnitTest
{
    public class MathHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CenariosNumerosDivisores()
        {
            #region Cenário válido - valor 45
            
            List<int> t1ResultadoReal = (List<int>)MathUtils.NumerosDivisores(45);
            List<int> t1ResultadoEsperado = new List<int>() { 1, 3, 5, 9, 15, 45 };
            Assert.AreEqual(t1ResultadoReal, t1ResultadoEsperado);

            #endregion
        }

        [Test]
        public void CenariosNumerosPrimosTests()
        {
            #region Cenário válido - valor { 1, 3, 5, 9, 15, 45 }

            List<int> t1DadosDeEntrada = new List<int>() { 1, 3, 5, 9, 15, 45 };

            List<int> t1ResultadoReal = (List<int>)MathUtils.NumerosPrimos(t1DadosDeEntrada);
            List<int> t1ResultadoEsperado = new List<int>() { 3, 5 };
            Assert.AreEqual(t1ResultadoReal, t1ResultadoEsperado);

            #endregion

            #region Cenário válido - valor { 1, 2, 4, 8 }

            List<int> t2DadosDeEntrada = new List<int>() { 1, 2, 4, 8 };

            List<int> t2ResultadoReal = (List<int>)MathUtils.NumerosPrimos(t2DadosDeEntrada);
            List<int> t2ResultadoEsperado = new List<int>() { 2 };
            Assert.AreEqual(t2ResultadoReal, t2ResultadoEsperado);

            #endregion

            #region Cenário válido - valor { 1 }

            List<int> t3DadosDeEntrada = new List<int>() { 1 };

            List<int> t3ResultadoReal = (List<int>)MathUtils.NumerosPrimos(t3DadosDeEntrada);
            List<int> t3ResultadoEsperado = new List<int>();
            Assert.AreEqual(t3ResultadoReal, t3ResultadoEsperado);

            #endregion
        }
    }
}