module Algorithms.Searching.Arrays

// Given a collection C of orderable data values and a data value v, is v in C?
let arraySliceRange (a: int array) (i: int) (j: int) =
    if i > j then Array.empty
    else a[i..j]

let arraySlice (a: int array) (i: int) =
    a[i..]