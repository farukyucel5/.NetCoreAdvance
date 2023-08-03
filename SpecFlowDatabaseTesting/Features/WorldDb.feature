Feature: World Database testing
@mytag
Scenario Outline:  Verify that cities can be retrieved properly
	Given fetch the list of the cities from the table city
	And verify that "<city>" exists in the table
	Examples:
	| city   |
	| Antalya |
	| Erzurum |
	| Ankara  |

	