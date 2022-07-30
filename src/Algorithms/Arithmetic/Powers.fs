module Algorithms.Arithmetic.Powers

open Algorithms.Arithmetic.BasicArithmetic

let rec raiseToPower b n =
    match n with
    | 0 -> 1
    | n -> mult (raiseToPower b (minus n 1)) b


let rec raiseToPowerRec b n = 
    match n with
    | 0 -> 1
    | n when n % 2 = 0 -> raiseToPowerRec (pown b 2) (divide n 2)
    | _ -> mult (raiseToPowerRec (pown b 2) (divide n 2)) b