using Develier.Simple_IoC.Core;
using NUnit.Framework;

namespace Develier.Simple_IoC.Tests
{
    public class ContainerShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateCorrectInstance_Given_A_Type()
        {
            Container container = new Container();

            container.Resolve();

            Assert.Pass();
        }
    }



}