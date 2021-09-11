using MathHelper;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using SimpleMathAPI.Controllers;
using System.Collections.Generic;

namespace NUnitTest
{
    public class SimpleMathAPITests
    {
        private SimpleMathController simpleMathController;

        [SetUp]
        public void Setup()
        {
            using var fact = LoggerFactory.Create(builder => builder.AddConsole());
            simpleMathController = new SimpleMathController(fact.CreateLogger<SimpleMathController>());
        }

        [Test]
        public void CenariosNumerosDivisores()
        {
            #region Cenário válido - valor 45

            List<int> t1ResultadoReal = (List<int>)simpleMathController.GetDivisores(45);
            List<int> t1ResultadoEsperado = new List<int>() { 1, 3, 5, 9, 15, 45 };
            Assert.AreEqual(t1ResultadoReal, t1ResultadoEsperado);

            #endregion
        }

        [Test]
        public void CenariosNumerosPrimosTests()
        {
            #region Cenário válido - valor 45

            List<int> t1ResultadoReal = (List<int>)simpleMathController.GetNumerosPrimos(45);
            List<int> t1ResultadoEsperado = new List<int>() { 3, 5 };
            Assert.AreEqual(t1ResultadoReal, t1ResultadoEsperado);

            #endregion

            #region Cenário válido - valor 8


            List<int> t2ResultadoReal = (List<int>)simpleMathController.GetNumerosPrimos(8);
            List<int> t2ResultadoEsperado = new List<int>() { 2 };
            Assert.AreEqual(t2ResultadoReal, t2ResultadoEsperado);

            #endregion

            #region Cenário válido - valor  1 

            List<int> t3ResultadoReal = (List<int>)simpleMathController.GetNumerosPrimos(1);
            List<int> t3ResultadoEsperado = new List<int>();
            Assert.AreEqual(t3ResultadoReal, t3ResultadoEsperado);

            #endregion
        }
    }
}