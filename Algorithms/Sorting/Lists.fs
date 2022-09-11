module Algorithms.Sorting.Lists

/// <summary>Generates a list of random numbers</summary>
/// <param name="count">The amount of numbers in the list</param>
/// <param name="min">The smallest number in the list</param>
/// <param name="max">The largest number in the list</param>
let randList count min max =
    let rnd = System.Random()
    List.init count (fun _ -> rnd.Next(min, max))

/// <summary>Generates an orderd list</summary>
/// <param name="min">The smallest number in the list</param>
/// <param name="max">The largest number in the list</param>
let orderedList min max = [ min..max ]

/// <summary>Generates a reverse ordered list</summary>
/// <param name="min">The smallest number in the list</param>
/// <param name="max">The largest number in the list</param>
let reverseOrderdList min max = [ max..min ]
