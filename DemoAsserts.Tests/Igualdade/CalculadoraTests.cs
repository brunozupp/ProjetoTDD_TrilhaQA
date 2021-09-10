using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.Igualdade
{   
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void DeveSomarDoisNumerosInteiros()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosInteiros(4, 6);

            Assert.That(resultado, Is.EqualTo(10));
        }

        [Test]
        public void DeveSomarDoisNumerosDecimais()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);

            Assert.That(resultado, Is.EqualTo(3.3));
        }

        [Test]
        public void DeveSomarDoisNumerosDecimais_UsandoWithin()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);

            Assert.That(resultado, Is.EqualTo(3.3).Within(0.01)); // Tolerância de 0.01
        }

        [Test]
        public void DeveSomarDoisNumerosDecimais_UsandoWithinPorcentagem()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(50, 50); // 100%

            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent); // Tolerância de 1%
        }

        [Test]
        public void DevoSomarDoisNumerosDecimais_NaoBomExemploUsarWithin()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);

            Assert.That(resultado, Is.EqualTo(30).Within(1000)); // Em qualquer lugar entre -70 a 130
        }

        [Test]
        public void DeveDividir()
        {
            var sut = new Calculadora();
        }
    }
}
