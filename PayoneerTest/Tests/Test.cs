using FluentAssertions;
using NUnit.Framework;
using PayoneerTest.Helpers;
using PayoneerTest.TestSteps;
using VF.Serenity.AutomationFramework;
using VF.Serenity.AutomationFramework.Infrastructure.Driver;

namespace PayoneerTest.Tests
{
    [TestFixture]
    public class Test
    {
        [SetUp]
        public void Precondition() =>
            DriverService.Driver.Get("https://payouts.payoneer.com/partners/or.aspx?pid=Y0LwV0AQC7cY%2b5AIqsZl1g%3d%3d%2");

        [Test]
        public void Reg_Test()
        {
            var model = GeneratorModelFactory.GetCompanyUserModel();

            Steps.RegistrationStep
                .RegistAsCompanyUser(model)
                .SuccessNotification.GetText()
                .Should()
                .Be("Thank You");
        }

        [TearDown]
        public void TearDown()
        {
            TestsBootstrap.Instance.Dispose();
            DriverService.Driver.Close();
        }

    }
}

