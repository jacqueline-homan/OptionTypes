  type Accessible =
        | Blind
        | Deaf
        | HeartCondition
        | Mobility

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