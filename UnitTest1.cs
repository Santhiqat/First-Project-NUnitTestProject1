using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace First_Project_NUnitTestProject1
{
    public class Tests
    {
        IWebDriver Driver;
        string url = "https://www.saucedemo.com";
        [SetUp]
        public void Setup()
        {

            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(6);

            Thread.Sleep(10000);
            Driver.Url = url;




        }

        [Test,Order(1)]
        public void LoginSuaceDemo()
        {
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(10000);
            Selectitem("Sauce Labs Bike Light");
            Checkout();
            shippingdetails();
            placeorder();




            Assert.Pass();
           // Assert.AreEqual("Text", "");
        }
        [Test, Order(2)]
        public void Addseconditem()
        {
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(10000);
            Selectitem("Sauce Labs Backpack");
            Checkout();
            shippingdetails();
            placeorder();




            Assert.Pass();
            // Assert.AreEqual("Text", "");
        }
        //[Test, Order(2)]
        public void Selectitem (string item)
        {
            Driver.FindElement(By.XPath("//div[contains(text(),'"+item+"')]")).Click();
            

        }

        //[Test,Order(3)]
        public void Checkout()
        {
            Thread.Sleep(10000);
            Driver.FindElement(By.XPath("//button[@class='btn_primary btn_inventory']")).Click();
            Thread.Sleep(10000);
            Driver.FindElement(By.XPath("//*[name()='path' and contains(@fill,'currentCol')]")).Click();
            Thread.Sleep(10000);
            Driver.FindElement(By.XPath("//a[@class='btn_action checkout_button']")).Click();
            Thread.Sleep(10000);



        }
        //[Test,Order(4)]
        public void shippingdetails()
        {
            Driver.FindElement(By.XPath("//input[@id='first-name']")).SendKeys("Testfirstname");
            Driver.FindElement(By.XPath("//input[@id='last-name']")).SendKeys("Testlastname");
            Driver.FindElement(By.XPath("//input[@id='postal-code']")).SendKeys("90021");
            Driver.FindElement(By.XPath("//input[@class='btn_primary cart_button']")).Click();
            Thread.Sleep(10000);

        }
        
        //[Test, Order(5)]
        public void placeorder()
        {
            Driver.FindElement(By.XPath("//a[@class='btn_action cart_button']")).Click();



        }
        [TearDown]
        public void Closebrowser()
        {
            Driver.Quit();




        }
    }
}