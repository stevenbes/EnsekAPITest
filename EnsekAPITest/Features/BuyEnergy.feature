Feature: BuyEnergy

A short summary of the feature

@tag1
Scenario: Buy energy for each energy type
	Given I send a PUT request for the following energy and units required
		| Type | Units |
		| Gas  | 100   |
		| Elec | 100   |
		| Oil  | 10    |
	Then using the order ID verify the orders have been added
