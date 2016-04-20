namespace OptionTypes
open System.Collections

module Domain =

    type Airline = { Name : string}
         
                    
    type Passenger =
        | FirstClass
        | BusinessClass
        | Coach

      type Accessible =
        | Blind
        | Deaf
        | HeartCondition
        | Mobility  

    type DietaryNeeds =
        | GlutenFree
        | LowSodium
        | SugarFree
        | Regular

    type Requests =
        | Seating of Set<Accessible>
        | Meals of Set<DietaryNeeds>

    type Booking = Booking of Passenger * Accessible * DietaryNeeds * Requests
