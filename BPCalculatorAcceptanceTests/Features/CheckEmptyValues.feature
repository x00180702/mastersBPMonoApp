Feature: Test to check user entering empty values
@test
Scenario: Check Range values details
	Given is on the Blood Pressure Calcultor Page
	And the user clears the Systolic field on the Blood Pressure Calcultor Page
	And the user clears the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then 'Systolic' field is required message is diplayed on the Blood Pressure Calcultor Page
	Then 'Diastolic' field is required message is diplayed on the Blood Pressure Calcultor Page
