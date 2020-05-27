using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TeamCss__Registration.Hooks;
using TeamCss__Registration.Utilities;

namespace TeamCss__Registration.PageObject
{
    class LogInPage
    {
        IWebDriver driver;
        Wait wait = new Wait();

        public LogInPage()

        {
            driver = Hook.driver;

        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/home");
        }

        IWebElement clickOnSignIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='user_email'] "));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement clickOnSignInlink => driver.FindElement(By.XPath("(//input[@class='add-p new-add-p'])[1]"));
        IWebElement dashboardElementDisplayed => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div[1]/div/div[2]/h2/span"));
        IWebElement ClickOnProfileName => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[4]/span"));
        IWebElement ClickOnLogout => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[4]/span"));
        IWebElement logoutelementDisplayed => driver.FindElement(By.XPath("(//*[@href='/home'])[1]"));
        IWebElement WebHomePageDisplayed => driver.FindElement(By.XPath("(//a[@href='/Account/profile'])[3]"));
        IWebElement ClickOnCommunity => driver.FindElement(By.XPath("//*[@id='mycommunity']/div[2]/a"));
        IWebElement Communitydashboarddisplayed => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[2]/div[1]/div/div[1]/h2"));

        IWebElement ClickOnSearch => driver.FindElement(By.XPath("html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[2]/a"));
        IWebElement SearchListShouldBeDisplayed => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div[1]/div/h2"));
        public bool LogoutElementDisplayed()
        {
            return wait.WaitForElement(driver, logoutelementDisplayed).Displayed;
        }
        public void SignInLink()
        {
            clickOnSignIn.Click();
        }

        public void ValidEmailAddress()
        {
            enterEmailAddress.SendKeys("Sophia.john@gmail.com");
        }

        public void Validpassword()
        {
            enterPassword.SendKeys("bluesky");
        }

        public void SignInButton()
        {
            clickOnSignInlink.Click();
        }

        public bool DashboardElementDisplayed()
        {
            return dashboardElementDisplayed.Displayed;
        }


        public void clickOnProfileName()
        {
            wait.WaitForElement(driver, ClickOnProfileName).Click();
        }

        internal bool? ItemsShouldBeDisplayed()
        {
            throw new NotImplementedException();
        }

        public void clickOnLogout()
        {
            ClickOnLogout.Click();
        }

        public bool WebPageDisplayed()
        {
            return wait.WaitForElement(driver, WebHomePageDisplayed).Displayed;
        }

        public void ClickOnCommunityLink()
        {
            ClickOnCommunity.Click();
        }

        public bool CommunityDashboardDisplayed()
        {
            return Communitydashboarddisplayed.Displayed;

        }

        public void ClickOnSearchButton()
        {
            ClickOnSearch.Click();
        }

        public bool SearchListDisplayed()
        {
            return SearchListShouldBeDisplayed.Displayed;
        }

     }

    }






