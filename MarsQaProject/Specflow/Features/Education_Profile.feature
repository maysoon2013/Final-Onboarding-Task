Feature: Education_Profile

As a Seller I want to Add, Update and Delete rducation in my Profile


Scenario Outline:Add Education in profile details
	Given I logged in Mars project account successfully
	When I navigate to Education Page by clicking Education
	And I Click on AddNew and enter '<University>', Country, Title,'<Degree>'Graduation Year and click on Add
	Then The education record should be added successfully
Examples: 
| University | Degree |
| DIU        | CSE    |
