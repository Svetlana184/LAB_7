using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace LAB_7
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void mainTitle()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://github.com/";
            var t = webDriver.Title;
            Assert.That(webDriver.Title, Is.EqualTo("GitHub · Change is constant. GitHub keeps you ahead. · GitHub"));
            webDriver.Close();
            webDriver.Quit();
        }
        [TestCase]
        public void googleRequest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.dns-shop.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"header-mobile-inner\"]/div[2]/div[1]/div/div/div[1]/div/input"));
            search.SendKeys("автоматизированное тестирование");
            webDriver.Close();
            webDriver.Quit();
        }
        [TearDown]
        public void testEnd()
        {

        }
    }
}
