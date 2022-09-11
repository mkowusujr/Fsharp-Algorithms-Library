module Algorithms.Arithmetic.Powers

open Algorithms.Arithmetic.BasicArithmetic

let rec raiseToPower baseNum exponent =
    match exponent with
    | 0 -> 1
    | n -> mult (raiseToPower baseNum (minus n 1)) baseNum


let rec raiseToPowerRec baseNum exponent =
    match exponent with
    | 0 -> 1
    | exponent when exponent % 2 = 0 -> raiseToPowerRec (pown baseNum 2) (divide exponent 2)
    | _ -> mult (raiseToPowerRec (pown baseNum 2) (divide exponent 2)) baseNum
