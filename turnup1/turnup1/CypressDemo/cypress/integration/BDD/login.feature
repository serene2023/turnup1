Feature: Login to Turnup portal

    Scenario: Login to Turnup portal successfully
    Given I have navigated to the turnup portal page
    When I input username
    And I input password
    And I click login button
    Then I should see the homepage displayed successfully