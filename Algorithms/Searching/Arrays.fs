module Algorithms.Searching.Arrays

let arraySliceRange (a: int array) (i: int) (j: int) =
    if i > j then Array.empty
    else a[i..j]

let arraySlice (a: int array) (i: int) =
    a[i..]