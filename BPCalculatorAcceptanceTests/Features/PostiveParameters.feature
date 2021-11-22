Feature: Test to check user enters values for all catagories 

@test
Scenario: Check Low details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 70 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 40 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result Low Blood Pressure will be diplayed on the Blood Pressure Calcultor Page


Scenario: Check Ideal details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 100 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 50 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result Ideal Blood Pressure will be diplayed on the Blood Pressure Calcultor Page


Scenario: Check Pre High details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 140 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 85 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result Pre-High Blood Pressure will be diplayed on the Blood Pressure Calcultor Page


Scenario: Check High details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 170 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 100 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result High Blood Pressure will be diplayed on the Blood Pressure Calcultor Page