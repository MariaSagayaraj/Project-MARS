Feature:4_Skills
	As a seller
	I would like to add my skills detail and view it on the profile page 

Background:
	Given I click on the skills tab

@automation
Scenario Outline::1_Adding skills using valid inputs
	Given I click on Add New button of skills tab
	And I enter the skill details <skill>,<skilllevel>
	When I click on Add button of skills tab
	Then I validate that the new skill has been added successfully <skill>

	Examples:
		| skill | skilllevel   |
		| Java  | Expert       |
		| C#    | Intermediate |

Scenario:2_Edit an existing skill using valid input
	Given I edit the skill details <skill>,<EditSkill>
	When I click on the Update button of skills tab
	Then I validate that the skill has been edited successfully <EditSkill>

	Examples:
		| skill | EditSkill |
		| C#    | Drawing   |

Scenario:3_Delete an existing skill
	Given I click on Delete button of skills tab <deleteskill>
	Then I validate that the skill has been deleted successfully <deleteskill>

	Examples:
		| deleteskill |
		| Java        |