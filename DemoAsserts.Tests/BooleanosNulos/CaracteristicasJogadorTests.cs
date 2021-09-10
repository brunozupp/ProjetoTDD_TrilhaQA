using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.BooleanosNulos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void DeveGerarNomeRandomicoPorDefault()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Nome, Is.Not.Empty);
        }

        [Test]
        public void DeveVerificarNovoJogador()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.NovoJogador, Is.True);
        }

        [Test]
        public void DeveVerificarApelidoJogador()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Apelido, Is.Null);
        }
    }
}
