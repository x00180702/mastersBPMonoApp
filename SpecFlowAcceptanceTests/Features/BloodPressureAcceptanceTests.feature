Feature: Check Blood Pressure Values

@mytag
Scenario Outline: Check value for calculations
	Given user enters <Systolic> in Systolic 
	And user enters <Diastolic> in Diastolic
	Then the result should be <Result>


	Examples: 
    | Systolic	| Diastolic |	Result		|
    |    70		|   59		|   Low 		|
    |    119	|   60		|   Ideal 		|
	|    121	|   89		|   PreHigh		|
	|    190	|   90		|   High 		|
	|    195	|   101		|   NotValid 	|