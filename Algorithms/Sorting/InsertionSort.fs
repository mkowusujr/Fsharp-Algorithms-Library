module Algorithms.Sorting.InsertionSort

let rec private insert (x: int) (xs: int list) =
    match (x, xs) with
    | (x, []) -> [ x ]
    | (x, y :: ys) ->
        if x <= y then
            x :: y :: ys
        else
            y :: insert x ys

let rec isort list : int list =
    match list with
    | [] -> []
    | x :: xs -> insert (x) (isort xs)
