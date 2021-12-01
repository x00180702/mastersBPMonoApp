Feature: Test to check user entering negative values
@test
Scenario Outline: Negative Tests
Scenario: Check Range values details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 191 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 39 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then Invalid Systolic Value message is diplayed on the Blood Pressure Calcultor Page
	Then Invalid Diastolic Value message is diplayed on the Blood Pressure Calcultor Page


Scenario: Check Illegal Characters values details
	Given is on the Blood Pressure Calcultor Page
	And the user enters e in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters e in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then Please enter a valid number message is diplayed under the 'Systolic' field textbox on the Blood Pressure Calcultor Page
	Then Please enter a valid number message is diplayed under the 'Diastolic' field textbox on the Blood Pressure Calcultor Page

Scenario: Check Illegal Characters values details 2
	Given is on the Blood Pressure Calcultor Page
	And the user enters !"£$£$ in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters *&()££ in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then 'Systolic' field is required message is diplayed on the Blood Pressure Calcultor Page
	Then 'Diastolic' field is required message is diplayed on the Blood Pressure Calcultor Page

Scenario: Check Illegal Characters values details 3
	Given is on the Blood Pressure Calcultor Page
	And the user enters Blood in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters Calculator in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then 'Systolic' field is required message is diplayed on the Blood Pressure Calcultor Page
	Then 'Diastolic' field is required message is diplayed on the Blood Pressure Calcultor Page