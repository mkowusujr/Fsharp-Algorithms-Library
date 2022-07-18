module Algorithms.Arithmetic.Factorial

let rec factorial n =
    match n with
    | 0 -> 1
    | x -> factorial (n - 1) * n

let rec factorialAcc n a = 
    match n with
    | 0 -> a
    | x -> factorialAcc (n - 1) (n * a)