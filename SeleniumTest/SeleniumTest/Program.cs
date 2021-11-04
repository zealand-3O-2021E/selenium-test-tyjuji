using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Selenium!");
            IWebDriver driver = new FirefoxDriver();

            //driver.Navigate().GoToUrl(@"http://127.0.0.1:5500/start/index.html");
            driver.Navigate().GoToUrl(@"file:///C:/Users/tyjuj/source/repos/selenium-test-tyjuji/start/index.html");
            System.Console.WriteLine("driver url:" + driver.Url);

            //documentation for finding elements : https://www.selenium.dev/documentation/webdriver/locating_elements/


            // Task 2 find by id and sendkeys
            IWebElement Inputelement1 = driver.FindElement(By.Id("input1"));

            Inputelement1.SendKeys("asdasdasdasd");

            // Task 3 find by id and click
            IWebElement buttonElement = driver.FindElement(By.Id("testButton1"));
            buttonElement.Click();

            // Task 4 find id, click, click
            IWebElement buttonElement2 = driver.FindElement(By.Id("testButton2"));
            for (int i = 0; i < 10; i++)
            {
                buttonElement2.Click();
            }

            // Task 5
            Console.WriteLine($"{buttonElement.Text}, {buttonElement.GetAttribute("class")}, {buttonElement2.Text}, {buttonElement2.GetAttribute("class")}");

            // Task 6
            IWebElement appElement = driver.FindElement(By.Id("app"));
            var findButtonElement = appElement.FindElement(By.TagName("button"));
            Console.WriteLine(findButtonElement.Text);


            // Task 7
            var findClassElement = appElement.FindElement(By.ClassName("button"));
            Console.WriteLine(findClassElement.Text);






        }
    }
}
