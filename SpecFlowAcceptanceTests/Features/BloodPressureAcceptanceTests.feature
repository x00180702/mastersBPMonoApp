Feature: Check Blood Pressure Values

@mytag
Scenario Outline: Check value for calculations
	Given user enters <Systolic> in Systolic 
	And user enters <Diastolic> in Diastolic
	Then the result should be <Result>

	Examples: 
    | Systolic	| Diastolic |	Result		|
    |    70		|   59		|   Low 		|
	|    190	|   90		|   High 		|
	|    195	|   101		|   NotValid 	|
