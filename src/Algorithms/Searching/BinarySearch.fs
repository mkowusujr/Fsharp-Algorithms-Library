module Algorithms.Searching.BinarySearch

open Algorithms.Arithmetic.BasicArithmetic

let rec searchSlice (a: int array) (value: int): bool =
    match a with
    | [||] -> false
    | [|_|] -> false

let m (a: int array): int array = 
    Array.empty