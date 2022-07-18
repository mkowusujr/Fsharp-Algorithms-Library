module Algorithms.Arithmetic.Factorial

let rec factorial n =
    match n with
    | 0 -> 1
    | x ->  factorial (n - 1) * n