Feature: Tap and Pay

   As a registered user,
   I need a way to pay for my bus ride using a prepaid card that I can scan when I get on the bus,
   so that my travel is much more efficient and enjoyable

   Scenario: I am a registered user waiting for a bus and the bus arrives
   Given The bus arrives and I get on
   When I am on the bus I swipe my card to pay for my bus ride
   Then I enjoy my bus ride to the desired destination 