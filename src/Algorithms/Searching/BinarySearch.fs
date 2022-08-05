module Algorithms.Searching.BinarySearch

open Algorithms.Arithmetic.BasicArithmetic

let private findMiddleIndex (a: int array): int = 
    let middleIndex:double = divide (minus (a.Length) (1)) (2)
    let middleIndexFloor = floor (middleIndex)
    int middleIndexFloor

let rec searchSlice (a: int array) (value: int): bool =
    let middleIndex: int = findMiddleIndex a
    match a with
    | [||] -> false
    | [|_|] ->
        if value = a[middleIndex] then true
        elif value < a[middleIndex] then true
        elif value > a[middleIndex] then true
