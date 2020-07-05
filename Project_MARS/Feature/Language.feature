Feature:3_Language
	As a seller
	I would like to add my language details and view it on the profile page

Background:
	Given I click on the Language tab

@Add_Language
Scenario:1_Add a language using valid input
	Given I click on Add New button of Language tab
	And I enter the language details <language>,<languagelevel>
	Then I click on Add button of Language tab
	Then I validate that the new language has been added successfully <language>

	Examples:
		| language | languagelevel  |
		| English  | Fluent         |
		| Tamil    | Basic          |
		| French   | Conversational |

Scenario:2_Edit an existing language using valid input
	Given I click on Edit button of Language tab
	And I edit the language details <Editlanguage>
	Then I click on the Update button of Language tab
	Then I validate that the language has been edited successfully <Editlanguage>

	Examples:
		| Editlanguage |
		| Spanish      |

Scenario:3_Delete an existing language
	Given I click on Delete button of Language tab
	Then I validate that the language has been deleted successfully