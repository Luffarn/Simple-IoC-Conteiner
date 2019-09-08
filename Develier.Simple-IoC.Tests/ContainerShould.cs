using Develier.Simple_IoC.Core;
using Develier.SimpleIoC.Tests.Fakes;
using NUnit.Framework;
using System;

namespace Develier.Simple_IoC.Tests
{
    public class ContainerShould
    {
        private Container _container { get; set; }

        [SetUp]
        public void Setup()
        {
            _container = new Container();
        }

        [TearDown]
        public void AfterTest()
        {
            _container = null;
        }

        [Test]
        public void ShouldCreateCorrectInstance_Given_A_Non_Registered_Type()
        {
            var entity = _container.GetInstance<Car>();

            Assert.AreEqual(entity.GetType(), typeof(Car));
        }

        [Test]
        public void Should_Map_Person_Entity_To_Car_Given_Registration()
        {
            _container.Register<IPerson, Person>();

            var entity = _container.GetInstance<IPerson>();

            Assert.AreEqual(entity.GetType(), typeof(Person));
        }
    }



}