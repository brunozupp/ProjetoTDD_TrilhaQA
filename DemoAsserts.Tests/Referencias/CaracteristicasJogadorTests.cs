using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.Referencias
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {

        [Test]
        public void CompararReferenciaDeObjeto()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            Assert.That(jogador1, Is.SameAs(jogador2));
        }

        [Test]
        public void CompararReferenciaDeObjetoDeMesmaReferencia()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = jogador1;

            Assert.That(jogador1, Is.SameAs(jogador2));
        }

        [Test]
        public void CompararReferenciaDeObjetoDiferentes()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            Assert.That(jogador1, Is.Not.SameAs(jogador2));
        }
    }
}
