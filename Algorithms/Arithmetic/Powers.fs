module Algorithms.Arithmetic.Powers

open Algorithms.Arithmetic.BasicArithmetic

/// <summary>Recusively performs exponential math</summary>
/// <param name="baseNum">The base number</param>
/// <param name="exponent">The exponent</param>
let rec raiseToPower baseNum exponent =
    match exponent with
    | 0 -> 1
    | n -> multiply (raiseToPower baseNum (subtract n 1)) baseNum

/// <summary>Recusively performs exponential math with divide and conquor</summary>
/// <param name="baseNum">The base number</param>
/// <param name="exponent">The exponent</param>
let rec raiseToPowerRec baseNum exponent =
    match exponent with
    | 0 -> 1
    | exponent when exponent % 2 = 0 -> raiseToPowerRec (pown baseNum 2) (divide exponent 2)
    | _ -> multiply (raiseToPowerRec (pown baseNum 2) (divide exponent 2)) baseNum
