module Algorithms.Sorting.QuickSort

/// <summary>
/// Splits the given list into 3 lists
/// based on whether the elements are less, same, or greater than the pivot
/// </summary>
/// <param name="list">The given list</param>
/// <param name="p">The pivot value</param>
/// <param name="lLess">The list of values less than the pivot</param>
/// <param name="lSame">The list of values same as the pivot</param>
/// <param name="lGreater">The list of values greater than the pivot</param>
let rec partitionHelper (list: int list) (p: int) (lLess: int list) (lSame: int list) (lGreater: int list) =
    match list with
    | [] -> lLess, lSame, lGreater
    | x :: xs ->
        if x < p then
            partitionHelper (xs) (p) (x :: lLess) (lSame) (lGreater)
        elif x > p then
            partitionHelper (xs) (p) (lLess) (lSame) (x :: lGreater)
        else
            partitionHelper (xs) (p) (lLess) (x :: lSame) (lGreater)

/// <summary>
/// Splits the given list into 3 lists
/// based on whether the elements are less, same, or greater than the pivot
/// </summary>
/// <param name="list">The given list</param>
/// <param name="p">The pivot value</param>
let partition (list: int list) (p: int) =
    let lLess: int list = []
    let lSame: int list = []
    let lGreater: int list = []
    partitionHelper list p lLess lSame lGreater

/// <summary>Performs quick sort on a list</summary>
/// <param name="list">The given list</param>
let rec qSort (list: int list) =
    match list with
    | [] -> []
    | x :: xs ->
        let lLess, lSame, lGreater = partition xs x
        (qSort lLess) @ (qSort (x :: lSame)) @ (qSort lGreater)
