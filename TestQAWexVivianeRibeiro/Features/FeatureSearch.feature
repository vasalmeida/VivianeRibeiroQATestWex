Feature: FeatureSearch
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Validity the Search Funcionality
	Given I navigate to the website https://www.wexinc.com/
	And Navigate in the Search section
	And Navigate on a filter at Combo Box
	And I Choose filter about Corporate Payments
	And I Click Enter without a Search Item
	Then The alert Please enter a search term are displayed