using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.Excecoes
{
    [TestFixture]
    public class CalculadoraTests
    {   
        [Test]
        public void DeveRetornarErroQuandoDividerPorZero()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 0), Throws.Exception);
        }

        [Test]
        public void DeveRetornarErroEspecificoQuandoDividerPorZero()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(99, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void DeveRetornarErroEspecificoQuandoDividerPorZero_Errado()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void DeveRetornarErroQuandoNumeroMaiorDoQueCem()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void DeveRetornarErroQuandoNumeroMaiorDoQueCem_MelhorCaso()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>().With.Matches<ArgumentOutOfRangeException>(v => v.ParamName.Equals("por")));
        }
    }
}
