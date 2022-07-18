module Algorithms.Sorting.InsertionSort

let rec private insert (x: 'a) (xs: list<'a>): list<'a> =
    match (x, xs) with
    | x, [] -> [x]
    | x, y::ys -> 
        if x <= y then
            x :: y :: ys
        else
            y :: insert x ys

let rec isort (list: list<'a>): list<'a> = 
    match list with
    | [] -> []
    | x :: xs -> insert (x) (isort xs)
