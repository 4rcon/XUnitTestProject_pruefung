Scenario: return pi Math.PI 
    Given the object Math.pi
    When calling pi function
    Then the result should be exaclty pi

Scenario: return Sin from <number>
    Given <number> and object Math
    When passing <number> 
    Then should return Sin(number)

Scenario: return Cos from <number>
    Given <number> and object Math
    When passing <number> 
    Then should return Sin(number)

Scenario: return Tang from <number>
    Given <number> and object Math
    When passing <number> 
    Then should return Sin(number)