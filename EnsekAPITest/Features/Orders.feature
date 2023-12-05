Feature: Orders

A short summary of the feature

@tag1
Scenario: Confirm how many orders have been placed before the current date
	Given I Get the number of current 
	When I place an order
	Then The current number of order should have increased
