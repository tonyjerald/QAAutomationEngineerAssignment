using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using NUnit;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
//using OpenQA;


namespace QAAutomationEngineerAssignment

{

    //public abstract class testbase
    //{
    //    public abstract void Test();
    //}
    public class QAAutomationEngineerAssignment //: testbase
    {

        //driver

        //[Test]
        //public override void Test()
        // {
        //     driver.Navigate().GoToUrlAsync("");
        //     var t6 = "sdf";
        //     ClassicAssert.Equals("test",t6);

        // }


        public static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrlAsync("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@aria-label= 'Search Amazon.in']")).SendKeys("Titan watch" + Keys.Enter);
            var webElements = driver.FindElements(By.XPath("//div[@role= 'listitem']"));

            foreach (var i in webElements)
            {
                //if (!i.FindElement(By.XPath("//*[contains(text(),'Sponsored')]")).Text.Contains("Sponsored"))
                //{

                ProductDetails details = new ProductDetails();
                details.Name = i.FindElement(By.ClassName("s-line-clamp-2")).Text;
                details.Price = i.FindElement(By.XPath("//*[@class='a-price-whole']")).Text;
                details.Link = i.FindElement(By.XPath("//a[@class= 'a-link-normal s-line-clamp-2 s-link-style a-text-normal']"))!;
                Actions action = new Actions(driver);

                action.KeyDown(Keys.Control).Click(details.Link).KeyUp(Keys.Control).Perform();

                List<string> tabs = new List<string>(driver.WindowHandles);
                driver.SwitchTo().Window(tabs[1]);
                driver.FindElement(By.Id("add-to-cart-button")).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.FindElement(By.Id("attachSiNoCoverage-announce")).FindElement(By.XPath("..")).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.FindElement(By.XPath("//input[@name='proceedToRetailCheckout']")).FindElement(By.XPath("..")).Click();
                driver.Close();
                driver.SwitchTo().Window(tabs[0]);
                // }
            }

        }
    }

}