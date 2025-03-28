Feature: ABNTest

A short summary of the feature

@TestTagExample
Scenario: Validate ABN Lookup Landing page
	Given I open ABN Lookup webpage
	When ABN Lookup page is open
	Then The page is validated

Scenario: Search Fiable on ABN Lookup
	Given I open ABN Lookup webpage
	When I search Fiable on the ABN Lookup page
	Then list with Fiable matching name will appear
	When I click the ABN for Fiable PTY LTD
	Then I will see the details of the entity

Scenario: Search Invalid ABN on ABN Lookup
	Given I open ABN Lookup webpage
	When I search invalid ABN
	Then No matching names are found

Scenario: Search Fiable using advance search
	Given I open ABN Lookup webpage
	When I open advance search
	Then I search fiable on advance search page
	Then list with Fiable matching name will appear
	When I click the ABN for Fiable PTY LTD
	Then I will see the details of the entity

