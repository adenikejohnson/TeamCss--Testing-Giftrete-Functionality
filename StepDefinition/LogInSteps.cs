using NUnit.Framework;
using System;
using TeamCss__Registration.PageObject;
using TechTalk.SpecFlow;

namespace TeamCss__Registration.StepDefinition
{
    [Binding]
    public class LogInSteps

    {

        LogInPage logInPage;

        public LogInSteps()
        {
            logInPage = new LogInPage();
        }


        [Given(@"I navigate to www\.qa\.giftrete\.com")]
        public void GivenINavigateToWww_Qa_Giftrete_Com()
        {
            logInPage.NavigateToWebsite();
        }
        
        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            logInPage.SignInLink();
                
        }

        [When(@"I enter your email")]
        public void WhenIEnterYourEmail()
        {
            logInPage.ValidEmailAddress();
        }
        
        [When(@"I enter your password")]
        public void WhenIEnterYourPassword()
        {
            logInPage.Validpassword();  
        }
        
        [When(@"I click on Sign In")]
        public void WhenIclickOnSignIn()
        {
            logInPage.SignInButton();
        }

        [Then(@"I should be signed in")]
        public void ThenIShouldBeSignedIn()
        {
            Assert.True(logInPage.WebPageDisplayed());              
        }

        [When(@"I click on profile name")]
        public void WhenIClickOnYourProfileName()
        {
            logInPage.clickOnProfileName();
        }
        
        [When(@"I click on logout")]
        public void WhenIClickOnLogout()
        {
            logInPage.clickOnLogout();    
        }
        
        [Then(@"I should be logged out")]
        public void ThenIShouldBeLoggedOut()
        {
            Assert.True(logInPage.LogoutElementDisplayed());
        }

        [When(@"I click on Community")]
        public void WhenYouClickOnCommunity()
        {
            logInPage.ClickOnCommunityLink();
        }

        [Then(@"Communities should be displayed")]
        public void ThenCommunitiesShouldBeDisplayed()
        {
            logInPage.CommunityDashboardDisplayed();
        }

        [Then(@"I click on profile name")]
        public void ThenIClickOnProfileName()
        {
            logInPage.clickOnProfileName();
        }

        [Then(@"I click on logout")]
        public void ThenYouClickOnLogout()
        {
            logInPage.clickOnLogout();
        }

        //[Then(@"I should be logged out")]
        //public void ThenIShouldBeLoggedOut()
        //{
              
        //}

        [When(@"I click on Search")]
        public void WhenIClickOnSearch()
        {
            Assert.True(logInPage.SearchListDisplayed());
        }

        [Then(@"all items should be displayed")]
        public void ThenAllItemsShouldBeDisplayed()
        {
            Assert.True(logInPage.ItemsShouldBeDisplayed());
        }

        //[Then(@"you should be logged out\.")]
        //public void ThenYouShouldBeLoggedOut_()
        //{
        //    ScenarioContext.Current.Pending();
        //}


        [Then(@"you click on profile name")]
        public void ThenYouClickOnProfileName()
        {
    
        }

        //[Then(@"you should be logged out")]
        //public void ThenYouShouldBeLoggedOut()
        //{
           
        //}

        
    }
}
