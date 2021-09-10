using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.Colecoes
{   

    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void NaoDeveTerListaDeArmasVazia()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.All.Not.Empty); // Verifica se todos os elementos não são nulos
        }

        [Test]
        public void DeveTerArmaTeiaDeAranha()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Contains.Item("Teia de Aranha"));
        }

        [Test]
        public void DeveTerPeloMenosUmTipoDeArtificial()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.Some.Contains("Artificial"));
        }

        [Test]
        public void NaoDeveConterArmaVoar()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.None.EqualTo("Voar").IgnoreCase);
        }

        [Test]
        public void DeveConterExatamenteTodasAsArmas()
        {
            var sut = new CaracteristicasJogador();

            var listaArmasEsperadas = new List<string>()
            {
                "Agilidade",
                "Força",
                "Força Agilidade",
                "Teia de Aranha",
                "Inteligência Artificial"
            };

            Assert.That(sut.Armas, Is.EquivalentTo(listaArmasEsperadas));
        }

        [Test]
        public void ArmasDevemEstarEmOrdemAlfabetica()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.Ordered);
        }

        [Test]
        public void DeveConterDuasArmasDeForca()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.Exactly(2).EndWith("Força"));
        }
    }
}
