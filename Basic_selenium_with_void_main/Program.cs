using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_selenium_with_void_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Name("q"));
            //Thread.Sleep(2000);
            element.SendKeys("fleek it solutions");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//span[contains(text(),'Fleek')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//h3[contains(text(),'Top')]")).Click();
            Thread.Sleep(8000);
            driver.Close();      
        }
    }
}
