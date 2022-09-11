module Algorithms.Arithmetic.Factorial

/// <summary>Finds the factorial with the help of an accummulator</summary>
/// <param name="n">The number to find the factorial of</param>
let rec factorial n =
    match n with
    | 0 -> 1
    | x -> factorial (n - 1) * n

/// <summary>Finds the factorial with the help of an accummulator</summary>
/// <param name="n">The number to find the factorial of</param>
/// <param name="a">The accummulator</param>
let rec factorialAcc n a =
    match n with
    | 0 -> a
    | x -> factorialAcc (n - 1) (n * a)
