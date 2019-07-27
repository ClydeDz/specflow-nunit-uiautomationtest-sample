@google
Feature: Google
	In order to avoid silly mistakes
    As a math idiot
    I want to be told the sum of two numbers

@regression
Scenario: Can find search results
  Given I am on the google page for "https://www.google.com/ncr"
  When I search for "TestingBot"
  Then I should see title "TestingBot - Google Search"

Scenario: Can find search results two
  Given I am on the google page for "https://www.google.com/ncr"
  When I search for "TestingTot"
  Then I should see title "TestingTot - Google Search"