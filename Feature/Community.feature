Feature: Community
	As a registered User 
	I want to be able to edit the anme of my community

@Automation
Scenario: Edit Community Name
	Given I Navigate to the Giftrete Website 
	And I Click On Sign in
	And I Enter Email Address
	And I Enter Password
	And I Click On the Sign In button
	And I Click on Find Community
	And I Select My Community From List
	And I CLick On Manage Community
	And I Rename Community Name 
	When I Click On Update 
	#Then I Should Have Renamed My Community