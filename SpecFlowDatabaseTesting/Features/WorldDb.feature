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


Scenario Template: Verify whether data can be retrieved from the 'city' table by applying a filtering condition.
    Given fetch the list of data filtered by "<key>" from the city table
	And verify whether the retrieved data filtered by "<key>" is accurate
	Examples: 
	| key  |
	| An   |
	| Er   |
	| Bo   |

