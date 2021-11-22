Feature: Test to check user entering negative values
@test
Scenario: Check Range values details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 191 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 39 in the Diastolic field on the Blood Pressure Calcultor Page
	Then Invalid Systolic Value message is diplayed on the Blood Pressure Calcultor Page
	Then Invalid Diastolic Value message is diplayed on the Blood Pressure Calcultor Page
