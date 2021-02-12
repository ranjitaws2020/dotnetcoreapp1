
using demo_web_app.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Demo_web_app
{
    [TestClass]
    public class HomeControllerTest
    {
        public readonly ILogger<HomeController> _logger;

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_logger);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController(_logger);

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
