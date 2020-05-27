using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TeamCss__Registration.Hooks;

namespace TeamCss__Registration.PageObject
{
    class RegistrationPage
    {
        IWebDriver driver;


        IWebElement clickCreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2] "));
        IWebElement enterFirstName => driver.FindElement(By.XPath(" //*[@id='first_name']"));

        IWebElement enterLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement clickOnCountryCode => driver.FindElement(By.XPath("//*[@id='nav-register']/form/div[4]/div/div/div"));
        IWebElement selectCountrycode => driver.FindElement(By.XPath("//*[@id='iti-item-gb']/span[1]"));
        IWebElement enterPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='password']"));

        IWebElement confirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement clickCaptcha => driver.FindElement(By.XPath("//*[@id='rc-anchor-container']/div[3]/div[1]/div/div "));
        IWebElement clickRegister => driver.FindElement(By.XPath("//*[@id='btn_register']"));

        
        public void ClickRegister()
        {
            clickRegister.Click();
        }
        public void ClickCaptcha()
        {
            clickCaptcha.Click();

        }
        public void ConfirmPassword()
        {
            confirmPassword.SendKeys("bluesky");
            
        }
        
        public void EnterPassword()
        {
            enterPassword.SendKeys("bluesky");
          
        }
        public void EnterPhoneNumber()
        {
            enterPhoneNumber.SendKeys("07947970249");
        }
        public void SelectCountrycode()
        {
            selectCountrycode.Click();
        }
        public void ClickOnCountryCode()
        {
            clickOnCountryCode.Click();
        }
        public void EnterEmailAddress()
        {
            //enterEmailAddress.SendKeys("Sophia.john@gmail.com");
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(3000);
            enterEmailAddress.SendKeys("username" + randomInt + "@gmail.com");
        }
        public void EnterLastName()
        {
            enterLastName.SendKeys("Johnson");
        }
        public void EnterFirstName() 
        {
            enterFirstName.SendKeys("Sophia");
        }

     
        public void ClickCreateAccount()
        {
            clickCreateAccount.Click();
        }


        public RegistrationPage()
        {
            driver = Hook.driver;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/home");
        }

    }

}
