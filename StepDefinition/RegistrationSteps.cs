using System;
using TeamCss__Registration.PageObject;
using TeamCss__Registration.StepDefinition;
using TechTalk.SpecFlow;

namespace TeamCss__Registration.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage(); 
        }
        

        [Given(@"I navigate to the giftrete website")]
        public void GivenINavigateToTheGiftreteWebsite() 
        {
            registrationPage.NavigateToWebsite(); 
        }
        
        [When(@"I click on the Create Account button")]
        public void WhenIClickOnTheCreateAccountButton()
        {
            registrationPage.ClickCreateAccount();
        }
        
        [When(@"I  Enter First Name")]
        public void WhenIEnterFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I Enters Last Name")]
        public void WhenIEntersLastName()
        {
            registrationPage.EnterLastName();

        }
        
        [When(@"I Enters Email Address")]
        public void WhenIEntersEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }
        
        [When(@"I Click on Country code")]
        public void WhenIClickOnCountryCode()
        {
            registrationPage.ClickOnCountryCode();
        }
        
        [When(@"I Select country code")]
        public void WhenISelectCountryCode()
        {
            registrationPage.SelectCountrycode();
        }
        
        [When(@"I Enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();  
        }
        
        [When(@"I Enter Password")]
        public void WhenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I Confirm password")]
        public void WhenIConfirmPassword()
        {
            registrationPage.ConfirmPassword();
        }
        
        [When(@"I Click on captcha button")]
        public void WhenIClickOnCaptchaButton()
        {
            registrationPage.ClickCaptcha();
        }
        
        [When(@"I Click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            registrationPage.ClickRegister();
        }
        
        [Then(@"I Should be registered")]
        public void ThenIShouldBeRegistered()
        {
          
        }
    }
}
