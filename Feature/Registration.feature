Feature: Registration 
	In order to use Giftrete.com
	I must be registered
	 

@automation
Scenario: Valid Registration 
Given I navigate to the giftrete website 
When I click on the Create Account button
And I  Enter First Name 
And I Enters Last Name 
And I Enters Email Address 
And I Click on Country code
And I Select country code
And I Enter phone number 
And I Enter Password 
And I Confirm password 
#And I Click on captcha button 
And I Click on Register button 
Then I Should be registered 


