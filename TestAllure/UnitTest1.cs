using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace TestAllure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver("C:\\GiangNguyen\\C#\\DevSel");
            driver.Navigate().GoToUrl("https://demoqa.com/select-menu");
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Elements']"));//TagName
            element.Click();
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
