module Algorithms.Sorting.MergeSort

/// <summary>Sorts and merges the too halves of the list together</summary>
/// <param name="xs">The first list</param>
/// <param name="ys">The second list</param>
let rec private merge (xs: int list) (ys: int list) =
    match xs, ys with
    | [], ys -> ys
    | xs, [] -> xs
    | x :: xs, y :: ys ->
        if x < y then
            x :: merge (xs) (y :: ys)
        elif x > y then
            y :: merge (x :: xs) (ys)
        else
            x :: y :: merge xs ys

/// <summary>
/// Divides the elements in the list into two piles
/// with the help of two accumlator lists
/// </summary>
/// <param name="list">The given list</param>
/// <param name="accList1">The first accumlator list</param>
/// <param name="accList2">The second accumlator list</param>
let rec private d (list: int list) (accList1: int list) (accList2: int list) =
    match list with
    | [] -> (accList1, accList2)
    | [ x ] -> (x :: accList1, accList2)
    | x :: y :: ys -> d (ys) (x :: accList1) (y :: accList2)

/// <summary>
/// Hides accumlator from the user and performs merge sort
/// </summary>
/// <param name="list">The given list</param>
/// <param name="accList1">The first accumlator list</param>
/// <param name="accList2">The second accumlator list</param>
let rec private mSortHelper (list: int list) (accList1: int list) (accList2: int list) =
    match list with
    | [] -> []
    | [ _ ] -> list
    | _ ->
        let (b1, b2) = d list accList1 accList2
        merge (mSortHelper b1 accList1 accList2) ( mSortHelper b2 accList1 accList2)

/// <summary>Performs merge sort on a given list</summary>
/// <param name="list">The given list</param>
let mSort (list: int list) =
    let l1: int list = []
    let l2: int list = []
    mSortHelper list l1 l2
