module Algorithms.Searching.BinarySearch

open Algorithms.Searching.Arrays
open Algorithms.Arithmetic.BasicArithmetic

// Method 1
/// <summary>Finds the middle in the given array using the floor of the array's length divided in two</summary>
/// <param name="a">The given array</param>
let private findMiddleIndex (a: int array) : int =
    let middleIndex: double = divide (subtract a.Length 1) (2)
    let middleIndexFloor = floor (middleIndex)
    int middleIndexFloor

/// <summary>
/// Searches for a value in an array by starting in the middle,
/// than either moving up or down based on the comparasion of the value in the middle
/// and the value being searched for
/// </summary>
/// <param name="a">The given array</param>
/// <param name="value">The value being serched for in the array</param>
let rec searchSlice (a: int array) (value: int) : bool =
    let middleIndex: int = findMiddleIndex a

    if a.Length = 0 then
        false
    else if value < a[middleIndex] then
        searchSlice (arraySliceRange (a) (0) (middleIndex - 1)) (value)
    elif value > a[middleIndex] then
        searchSlice (arraySliceRange (a) (middleIndex + 1) (a.Length - 1)) (value)
    else
        true


// Method 2
/// <summary>>Finds the middle in the given array</summary>
/// <param name="leftIndex">The left index</param>
/// <param name="rightIndex">The right index</param>
let private findMiddleForSearchHelp (leftIndex: int) (rightIndex: int) : int =
    let middleIndex: double = divide (subtract (rightIndex) (leftIndex)) (2)
    leftIndex + int (floor (middleIndex))

/// <summary>
/// Searches for a value in an array by starting in the middle,
/// than either moving up or down based on the comparasion of the value in the middle
/// and the value being searched for
/// </summary>
/// <param name="a">The given array</param>
/// <param name="value">The value being serched for in the array</param>
/// <param name="leftIndex">The current left index being looked at</param>
/// <param name="rightIndex">The current right index being looked at</param>
let rec private searchHelp (a: int array) (value: int) (leftIndex: int) (rightIndex: int) : bool =
    let middleIndex = findMiddleForSearchHelp leftIndex rightIndex

    if leftIndex > rightIndex then
        false
    elif value = a[middleIndex] then
        true
    elif value < a[middleIndex] then
        searchHelp (a) (value) leftIndex (middleIndex - 1)
    else
        searchHelp (a) (value) (middleIndex + 1) (rightIndex)

/// <summary>Performs binary search on an array</summary>
/// <param name="a">The given array</param>
/// <param name="value">The value being searched for</param>
let search (a: int array) (value: int) : bool =
    searchHelp (a) (value) (0) (a.Length - 1)
