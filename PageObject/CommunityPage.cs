using OpenQA.Selenium; 
using TeamCss__Registration.Hooks;
using TeamCss__Registration.Utilities;

namespace TeamCss__Community.PageObject
{
    class CommunityPage
    {
        IWebDriver driver;

        Wait wait = new Wait();

        IWebElement clickOnSignIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement EnterEmailAddress => driver.FindElement(By.XPath("//*[@id='user_email'] "));

        IWebElement EnterPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));

        IWebElement clickSignIn => driver.FindElement(By.XPath("(//input[@class='add-p new-add-p'])[1]"));

        IWebElement FindCommunity => driver.FindElement(By.XPath("//*[@id='mycommunity']/div[2]/a "));


        IWebElement SelectMyCommunity => driver.FindElement(By.XPath("//*[@id='2182]/div[1]/img "));

        IWebElement ClickOnManageCommunity => driver.FindElement(By.XPath("//*[@id='content']/div[1]/div/div/div/div/div[2]/a[1] "));

        IWebElement RenameCommunity => driver.FindElement(By.XPath("//*[@id='name']"));

        IWebElement ClickOnUpdate => driver.FindElement(By.XPath("//*[@id='btn_update']"));

        
        public void ClickOnSignIn()
        {
            clickOnSignIn.Click();
        }

          public void enteremailAddress()
        {
           EnterEmailAddress.SendKeys("Sophia.john@gmail.com");
        }

        public void enterPassword()
        {
            EnterPassword.SendKeys("bluesky");
        }

        public void ClickSiginInButton()
        {
            wait.WaitForElement(driver, clickSignIn).Click();
        }            

        public void findCommunity()
        {
            FindCommunity.Click();
        }

        public void selectMyCommunity()
        {
            wait.WaitForElement(driver, SelectMyCommunity).Click();
        }

        public void clickOnManageCommunity()
        {
            ClickOnManageCommunity.Click();
        }

        public void renameCommunity()
        {
            RenameCommunity.SendKeys("TeamCss");
        }

        public void clickOnUpdate()
        {
            ClickOnUpdate.Click();

        }



      public CommunityPage()
      {
            driver = Hook.driver;
      }       



      public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/home");
        }

    }

}
