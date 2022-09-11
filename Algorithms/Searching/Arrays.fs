module Algorithms.Searching.Arrays

/// <summary>Performs an array slice with two indexes</summary>
/// <param name="a">The given array</param>
/// <param name="i">The starting slice index</param>
/// <param name="j">The ending slice index</param>
let arraySliceRange (a: int array) (i: int) (j: int) = if i > j then Array.empty else a[i..j]

/// <summary>Performs an array slice with one index</summary>
/// <param name="a">The given array</param>
/// <param name="i">The starting slice index</param>
let arraySlice (a: int array) (i: int) = a[i..]
