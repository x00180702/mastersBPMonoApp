﻿Feature: Blood Pressure Calcultor Tests
	Selenium tests for BP Calculator

@test
Scenario: Check details
	Given is on the Blood Pressure Calcultor Page
	And the user enters 70 in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters 40 in the Diastolic field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result Low Blood Pressure will be diplayed on the Blood Pressure Calcultor Page