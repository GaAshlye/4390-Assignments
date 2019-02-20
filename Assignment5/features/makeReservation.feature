Feature: Make Reservation

   As a registered qualified user (user who requests a bus to come pick them up at their house),
   I would like to be able to reserve a bus to come and pick me up at my house,
   so that I can go do my daily tasks

   Scenario: Qualified user requests a bus to come pick up at their house
   Given The user has already been approved and qualified for this service
   When they signed up for the service 
   Then The user requests a pick up time and gets picked up from their house