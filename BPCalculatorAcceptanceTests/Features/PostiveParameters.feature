Feature: Test to check user enters values for all catagories 

@test
Scenario Outline: Check All Catagory details
	Given is on the Blood Pressure Calcultor Page
	And the user enters <Systolic> in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters <Diastolic> in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result <Result> will be diplayed on the Blood Pressure Calcultor Page

	Examples: 
    | Systolic	| Diastolic |		Result				|
    |    70		|   40		|   Low Blood Pressure.		|
    |    100	|   50		|   Ideal Blood Pressure	|
	|    140	|   85		|   Pre-High Blood Pressure	|
	|    170	|   100		|   High Blood Pressure		|