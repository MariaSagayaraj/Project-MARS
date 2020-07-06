Feature:1_SignIn
	As a user, I should be Signed In successfully

@automation
Scenario: SignIn the portal
	Given Web browser is opened
	And I Navigate to the portal
	When I enter user credentials and press Login button <username>,<password>
	Then I validate that I logged into the portal successfully

	Examples:
		| username                | password |
		| maria.saronia@gmail.com | 123456   |