Feature: Test to check user entering empty values
@test
Scenario Outline: Empty and rearranged values

Scenario: Check Empty values details
	Given is on the Blood Pressure Calcultor Page
	And the user clears the Systolic field on the Blood Pressure Calcultor Page
	And the user clears the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then 'Systolic' field is required message is diplayed on the Blood Pressure Calcultor Page
	Then 'Diastolic' field is required message is diplayed on the Blood Pressure Calcultor Page

Scenario: Check values that are equal
	Given is on the Blood Pressure Calcultor Page
	And the user enters 100 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 100 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then Systolic must be greater than Diastolic message is diplayed on the Blood Pressure Calcultor Page

Scenario: Check Systolic values is Lower then Diastolic
	Given is on the Blood Pressure Calcultor Page
	And the user enters 80 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 100 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then Systolic must be greater than Diastolic message is diplayed on the Blood Pressure Calcultor Page
