Feature: Edit Account

   As I registered user,
   I need to be able to edit my account information
   so that I can keep my account current

   Scenario: I am a user who wishes to edit my account
   Given I am logged in and I wish to edit my account information
   When I am on my account page and I click the edit button
   Then My account information becomes editable
