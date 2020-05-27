Feature: LogIn
	In order to Log out as a registered User 
	I must be Logged in 

Background: 
Given I navigate to www.qa.giftrete.com
    When I click on Sign in
    And I enter your email
    And I enter your password
    And I click on Sign In
   Then I should be signed in


@Automation 
Scenario: Log in
	
   When I click on profile name
   And I click on logout
  Then I should be logged out

Scenario: Communitylogin
 
When I click on Community 
Then Communities should be displayed 
And I click on profile name 
And I click on logout
Then I should be logged out 

Scenario: Searchlogin

When I click on Search 
Then all items should be displayed 
And I click on profile name 
And I click on logout
Then I should be logged out


