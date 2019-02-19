Feature: Client Project

   As a client, I need a form to
   on the Coding Club Website
   So I can submit a project proposal to the Coding Club

   Scenario: Client Submits Project Proposal
   Given Client has a project they want done
   When Client fills out form (contact name, company, etc)
   Then Client form should be sent in with attached project after form is filled out
   