using NUnit.Framework;
using System;

namespace OverviewNUnitsAttributes.Tests
{
    [TestFixture]
    public class ClassTest
    {
        [Test, Ignore("Because of learning how it works")]
        public void SomeTest1()
        {
            bool value = true;
        }

        [Test, Explicit("Só vai rodar em algumas situações")]
        public void SomeTeste2()
        {
            bool value = true;
        }

        [Test, Category("Critical")]
        public void SomeTeste4()
        {
            bool value = true;
        }

        [Test, Category("Critical")]
        public void SomeTeste5()
        {
            bool value = true;
        }

        [Test]
        public void SomeTeste6()
        {
            bool value = true;
        }

        [OneTimeSetUp] // Executa primeiro antes de todos os testes, até mesmo antes do SetUp
        public void FixtureSetup()
        {
            bool value = true;
        }

        [OneTimeTearDown] // Executa por último, depois que passou por todos os testes, até mesmo depois do último TearDown executado
        public void FixtureTearDown()
        {
            bool value = true;
        }

        [SetUp] // Executa antes de cada teste, mas não executa antes do OneTimeSetUp
        public void SetUp()
        {
            bool value = true;
        }

        [TearDown] // Executa depois de cada teste
        public void TearDown()
        {
            bool value = true;
        }
    }
}
