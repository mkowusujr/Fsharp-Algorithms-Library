module Algorithms.Sorting.InsertionSort

/// <summary>
/// Compares head of list with head of tail
/// If the head is list is greater than the head of the tail, it is inserted after it
/// Else it is inserted before it
/// </summary>
/// <param name="x">The head of the list</param>
/// <param name="xs">The tail of the list</param>
let rec private insert (x: int) (xs: int list) =
    match (x, xs) with
    | (x, []) -> [ x ]
    | (x, y :: ys) ->
        if x <= y then
            x :: y :: ys
        else
            y :: insert x ys

/// <summary>Sorts a list with insertion sort</summary>
/// <param name="list">The list that needs to be sorted</param>
let rec isort list : int list =
    match list with
    | [] -> []
    | x :: xs -> insert (x) (isort xs)
