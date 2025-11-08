using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace LAB_8
{
    public class Tests
    {
        [TestCase]
        public void hallRequest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-infobars");
            IWebDriver webDriver = new ChromeDriver(options);
            webDriver.Url = "https://kaliningrad.gorko.ru/";
            IWebElement hall = webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/a"));
            hall.Click();
            webDriver.Url = "https://kaliningrad.gorko.ru/рестораны/";
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[1]/div[1]/div[3]"));
            button.Click();
            IWebElement price = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[1]/div[1]/div[3]/div[2]/div[2]/ul[1]/li/div/input"));
            price.Click();
            IWebElement gett = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[1]/div[1]/div[3]/div[2]/div[1]/a[2]"));
            gett.Click();

            //webDriver.Close();
            //webDriver.Quit();
        }
       
    }
}
