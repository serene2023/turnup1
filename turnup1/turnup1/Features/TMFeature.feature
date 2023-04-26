﻿Feature: TMFeature

As a TurnUp portal admin
I would like to create and edit time and material records
So that I can manage employees' time and material successfully

Scenario: Create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I create a new time and material record
	Then The record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I update '<description>' on an existing time and material record
	Then the record should have the updated '<description>'

Examples: 
| Description  | Code     | Price |
| Time         | Galen    | $5.00 |
| Material     | Keyboard | 100   |
| EditedRecord | Mouse    | 1500  |