module Algorithms.Sorting.Lists

let randList count min max=
    let rnd = System.Random()
    List.init count (fun _ -> rnd.Next(min, max))

let orderedList min max = 
    [min .. max]

let reverseOrderdList min max =
    [max .. min]