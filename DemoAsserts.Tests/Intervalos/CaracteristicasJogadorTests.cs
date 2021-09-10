using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.Intervalos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void DeveAumentarVidaJogadorDepoisDormir()
        {
            var sut = new CaracteristicasJogador { 
                Vida = 100
            };

            sut.Dormir();

            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

        [Test]
        public void DeveAumentarVidaJogadorDepoisDormir_Intervalo()
        {
            var sut = new CaracteristicasJogador
            {
                Vida = 100
            };

            sut.Dormir();

            Assert.That(sut.Vida, Is.InRange(101,200));
        }
    }
}
