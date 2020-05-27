using System;
using TeamCss__Community.PageObject;
using TechTalk.SpecFlow;

namespace TeamCss__Registration
{
    [Binding]
    public class CommunitySteps
    {
        CommunityPage communityPage;

        public CommunitySteps()
        {
            communityPage = new CommunityPage();
        }

        [Given(@"I Navigate to the Giftrete Website")]
        public void GivenINavigateToTheGiftreteWebsite()
        {
            communityPage.NavigateToWebsite();

        }
        
        [Given(@"I Click On Sign in")]
        public void GivenIClickOnTheSignInButton()
        {
            communityPage.ClickOnSignIn();
        }
        
        [Given(@"I Enter Email Address")]
        public void GivenIEnterEmailAddress()
        {
            communityPage.enteremailAddress();
        }
        
        [Given(@"I Enter Password")]
        public void GivenIEnterPassword()
        {
            communityPage.enterPassword();
        }
        
        [Given(@"I Click On the Sign In button")]
        public void GivenIClickOnTheSignIn()
        {
            communityPage.ClickSiginInButton();
        }
        
        [Given(@"I Click on Find Community")]
        public void GivenIClickOnFindCommunity()
        {
            communityPage.findCommunity();
        }
        
        [Given(@"I Select My Community From List")]
        public void GivenISelectMyCommunityFromList()
        {
            communityPage.selectMyCommunity();
        }
        
        [Given(@"I CLick On Manage Community")]
        public void GivenICLickOnManageCommunity()
        {
            communityPage.clickOnManageCommunity();
        }
        
        [Given(@"I Rename Community Name")]
        public void GivenIRenameCommunityName()
        {
            communityPage.renameCommunity();
        }
        
        [When(@"I Click On Update")]
        public void WhenIClickOnUpdate()
        {
            communityPage.clickOnUpdate();
        }
        
        [Then(@"I Should Have Renamed My Community")]
        public void ThenIShouldHaveRenamedMyCommunity()
        {
        
        }
    }
}
