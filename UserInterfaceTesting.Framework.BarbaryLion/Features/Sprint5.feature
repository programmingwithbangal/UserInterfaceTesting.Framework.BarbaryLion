@Sprint5Steps
Feature: Sprint5
As a user,
I want the ability to fill out the Sprint5 form.

  @AcceptanceCriteria
  Scenario: A user successfully fills out the form
    Given I go to the sample application page
	 When I fill out the first form and submit it
	 Then I should be redirected to the second form
	 When I fill out the second form and submit it
	 Then I should be redirected to the home page