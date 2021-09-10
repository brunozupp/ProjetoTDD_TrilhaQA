using DemoAsserts.Igualdade;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Tests.Igualdade
{
    [TestFixture]
    public class DatasEspeciaisStoreTests
    {
        [Test]
        public void DeveRetornarCorretamenteAnoNovo()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 0)));
        }

        [Test]
        public void DeveRetornarCorretamenteAnoNovo_UsandoWithin()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);

            // outra forma de fazer

            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
        }
    }
}
