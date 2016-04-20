open System
open System.IO
open OptionTypes.Domain


let fx(dn:Set<DietaryNeeds>) =
    Seq.iter (fun x ->
        match x with
        | GlutenFree -> printfn "gluten-free"
        | LowSodium -> printfn "low-sodium"
        | SugarFree -> printfn "sugar-free"
        | Regular -> printfn "regular")(dn)

let gx(sn:Set<Accessible>) =
    Seq.iter (fun x -> 
        match x with
        | Blind -> printfn "vision-impaired"
        | Deaf -> printfn "hearing-impaired"
        | HeartCondition -> printfn "glycerin patient"
        | Mobility -> printfn "ambulatory-impaired") (sn)

let passengerRequest(pr:Requests) =
    match pr with
    | Seating(sn) -> printfn "Special Seating"
    | Meals(dn) -> printfn "Dietary Needs"
                   fx(dn)
let itinerary() =
    printfn "Passenger Flight and Meal Plan:"

        
[<EntryPoint>]
let main argv = 
    let f = OptionTypes.InputBuilder.flight()
    let b = OptionTypes.InputBuilder.booking()
    let m = OptionTypes.InputBuilder.food()

  

         

    0 // return an integer exit code

