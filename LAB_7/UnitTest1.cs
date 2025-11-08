using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace LAB_7
{
    [TestFixture]
    public class Tests
    {
        //[TestCase]
        //public void mainTitle()
        //{
        //    IWebDriver webDriver = new ChromeDriver();
        //    webDriver.Url = "https://github.com/";
        //    var t = webDriver.Title;
        //    Assert.That(webDriver.Title, Is.EqualTo("GitHub · Change is constant. GitHub keeps you ahead. · GitHub"));
        //    webDriver.Close();
        //    webDriver.Quit();
        //}
        //[TestCase]
        //public void mailRequest()
        //{
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArguments("--disable-infobars");
        //    IWebDriver webDriver = new ChromeDriver(options);
        //    webDriver.Url = "https://mail.ru/";
        //    //IWebElement search = webDriver.FindElement(By.Name("search_source"));
        //    //search.SendKeys("автоматизированное тестирование");
        //    IWebElement button = webDriver.FindElement(By.XPath("/html/body/main/div[1]/div[2]/div/div/div[3]/div[1]/a"));
        //    button.Click();
        //    //webDriver.Close();
        //    //webDriver.Quit();
        //}
        [TestCase]
        public void ramblerRequest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-infobars");
            IWebDriver webDriver = new ChromeDriver(options);
            webDriver.Url = "https://www.rambler.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[3]/div/div[2]/form/input"));
            search.SendKeys("автоматизированное тестирование");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[3]/div/div[2]/form/button"));
            button.Click();
            //webDriver.Close();
            //webDriver.Quit();
        }
        [TearDown]
        public void testEnd()
        {

        }
    }
}
