namespace OptionTypes

module InputBuilder =
    open System
    open System.IO
    open OptionTypes.Domain

    let flight()  =
        printfn "What airline will you be booking with today?"
        let user = Console.ReadLine().Trim().ToUpper()
        user
        |> printfn "%s"

    let booking() =
        printfn "Will you be traveling First Class, Business Class, or Coach?"
        let user = Console.ReadLine().Trim().ToUpper()
        user
        |> printfn "%s" 

    let disability() : Set<Accessible> =
        let rec seating(s:Set<Accessible>) : Set<Accessible> =
            printfn "If you need disability accommodations, proceed through the following menu."
            printfn "Please enter accessibility needs and press 'Enter':"
            printfn "Enter 'done' when done"
            printfn "Otherwise, enter 'skip' to skip this section."
            printfn "Enter 'Blind', 'Deaf', 'Heart Condition',or 'Mobility-Impaired':"

            let customer = Console.ReadLine()
            match customer.Trim().ToLower() with
            | "done" -> s
            | _ ->
                let n = 
                    match customer.Trim().ToLower() with
                    | "blind" -> Blind
                    | "deaf" -> Deaf
                    | "mobility-impaired" -> Mobility
                    | "heart condition" -> HeartCondition
                    | _ -> printfn "Invalid Entry"
                           None
                match n with
                | None -> seating(s)
                | Some(x) -> seating(s.Add(x))
        seating(new Set<Accessible>([]))

    let food() : Set<DietaryNeeds> =
        let rec diet(s:Set<DietaryNeeds>) : Set<DietaryNeeds> =
            printfn "Please enter dietary needs one at a time and press 'Enter':"
            printfn "Enter 'done' when done"
            printfn "Choose from the following: Low Sodium, Sugar-Free, Gluten-Free, or Regular:"

            let passenger = Console.ReadLine()
            match passenger.Trim().ToLower() with
            | "done" -> s
            | _ -> 
                let n =
                    match passenger.Trim().ToLower() with
                    | "sugar-free" -> Some SugarFree
                    | "low-sodium" -> Some LowSodium
                    | "gluten-free" -> Some GlutenFree
                    | "regular" -> Some Regular
                    | _ -> printfn "Invalid entry" 
                           None
                match n with
                | None -> diet(s)
                | Some(x) -> diet(s.Add(x))
        diet (new Set<DietaryNeeds>([]))

