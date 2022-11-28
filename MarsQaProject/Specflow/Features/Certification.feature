Feature: Certification

As a Seller I want to Add,Update and Delete Certificate in my prifile


Scenario Outline: Add Certificate
	Given I logged into Mars project account successfully
	When  I navigate to Certification Page
	And I click on Add new and enter '<Certificate>', '<CertifiedFrom>' select year and click on add
	Then The certication should be added successfully 
	Examples: 
	| Certificate | CertifiedFrom   |
	| Tester      | IndustryConnect |