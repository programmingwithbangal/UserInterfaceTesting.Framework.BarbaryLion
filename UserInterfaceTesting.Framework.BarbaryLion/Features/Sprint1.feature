@Sprint1Steps
Feature: Sprint1
As a user,
I want the ability to fill out the Sprint1 form.

  @AcceptanceCriteria
  Scenario: A user successfully fills out the form
    Given I go to the sample application page
	 When I fill out the form and submit it
	 Then I should be redirected to the home page