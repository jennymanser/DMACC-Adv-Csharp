namespace FirstResponsiveWebAppLastName.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_ValidModel_ReturnsAgeView()
        {
            var controller = new HomeController();
            var model = new UserModel();

            object value = controller.ModelState.Clear();

            var result = controller.Index(model) as ViewAge;

            Assert.IsNotNull(result, "Result should be a ViewResult");
            Assert.AreEqual("Age", result.ViewName, "View name should be 'Age'");
            Assert.AreSame(model, result.Model, "Model should be passed to the view");
        }

        [TestMethod]
        public void Index_InvalidModel_ReturnsDefaultView()
        {
            
            var controller = new HomeController();
            var model = new UserModel();

            object value = controller.ModelState.AddModelError("TestError", "Invalid data");

            var result = controller.Index(model) as ViewResult;

            Assert.IsNotNull(result, "Result should be a ViewResult");
            Assert.IsTrue(string.IsNullOrEmpty(result.ViewName), "Default view should be returned");
            Assert.AreSame(model, result.Model, "Model should be passed to the view");
        }

        [TestMethod]
        public void Clear_ReturnsRedirectToIndex()
        {
            var controller = new HomeController();

            var result = controller.Clear() as RedirectToActionResult;

            Assert.IsNotNull(result, "Result should be a RedirectToActionResult");
            Assert.AreEqual("Index", result.ActionName, "Should redirect to 'Index'");
        }
    }

    internal class RedirectToActionResult
    {
        public string? ActionName { get; internal set; }
    }

    internal class ViewResult : ViewAge
    {
        public string? ViewName { get; internal set; }
        public UserModel? Model { get; internal set; }
    }
}



