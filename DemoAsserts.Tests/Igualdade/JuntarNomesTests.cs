using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using DemoAsserts.Igualdade;

namespace DemoAsserts.Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTests
    {
        [Test]
        public void DeveJuntarNomes()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Bruno", "Noveli");

            Assert.That(nomeCompleto, Is.EqualTo("Bruno Noveli"));
        }

        [Test]
        public void DeveJuntarNomes_CaseSensitive()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("bruno", "noveli");

            Assert.That(nomeCompleto, Is.EqualTo("BRUNO NOVELI").IgnoreCase);
        }

        [Test]
        public void DeveJuntarNomes_NaoIgual()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Bruno", "Noveli");

            Assert.That(nomeCompleto, Is.Not.EqualTo("José Lemos"));
        }
    }
}
