module Algorithms.Searching.BinarySearch

open Algorithms.Searching.Arrays
open Algorithms.Arithmetic.BasicArithmetic

// Method 1
let private findMiddleIndex (a: int array): int = 
    let middleIndex: double = divide (minus a.Length 1) (2)
    let middleIndexFloor = floor (middleIndex)
    int middleIndexFloor

let rec searchSlice (a: int array) (value: int): bool =
    let middleIndex: int = findMiddleIndex a
    if a.Length = 0 then false
    else
        if value < a[middleIndex] then searchSlice (arraySliceRange (a) (0) (middleIndex - 1)) (value)
        elif value > a[middleIndex] then searchSlice (arraySliceRange (a) (middleIndex + 1) (a.Length - 1)) (value)
        else true

// Method 2
let private findMiddleForSearchHelp (leftIndex: int) (rightIndex: int): int =
    let middleIndex:double = divide (minus (rightIndex) (leftIndex)) (2)
    leftIndex + int (floor (middleIndex))

let rec private searchHelp (a: int array) (value: int) (leftIndex: int) (rightIndex: int): bool =
    let middleIndex = findMiddleForSearchHelp leftIndex rightIndex
    if leftIndex > rightIndex then false
    elif value = a[middleIndex] then true
    elif value < a[middleIndex] then searchHelp (a) (value) leftIndex (middleIndex - 1)
    else searchHelp (a) (value) (middleIndex + 1) (rightIndex)

let search (a:int array) (value:int): bool =
    searchHelp (a) (value) (0) (a.Length - 1)
