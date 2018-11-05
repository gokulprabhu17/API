Feature: firsttest
	

@mytag
Scenario: get api response using endpoint
	Given I have a endpoint time/now
	When I call get method of api
	Then I get API response in json format

	
	Scenario Outline: get api response using a parameter
	Given I have a endpoint time/now
	When I call get method to get user information using <userid>
	Then I will get user information

Examples: userinfo
| userid   |
| user1001 |
       