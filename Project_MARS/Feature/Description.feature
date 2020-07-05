Feature:2_Description
	As a seller
	I would like to add my profile description and view it on the profile page

@Add Description
Scenario: Add a Description to the profile
	Given I click on the edit button of Description
	And I enter the description <description>
	And I click on Save button
	Then I validate that the description has been added successfully

	Examples:
		| description                      |
		| I am Maria. I am a Test Analyst. |