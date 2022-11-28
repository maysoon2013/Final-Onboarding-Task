Feature: Language

As a Seller I want to Add,Update and Delete languages into my Profile


Scenario Outline: Add Language in the Profile
	Given I logged into the Mars Project account successfully
	When I navigate to language page
	And I click on AddNew button
	And I Add '<Language>' and '<Level>' to the profile
	And T click on Add button
	Then The record of launage should be added successfully
	Examples: 
	| Language | Level  |
	| Bengoli  | Fluent |




	
