module Algorithms.Arithmetic.Sums

open Algorithms.Arithmetic.BasicArithmetic

/// <summary>The sum of numbers from one to n</summary>
/// <param name="n">The last number in the sum, must be greater than 1</param>
let sumTo n = divide (mult n (add n 1)) 2

/// <summary></summary>
/// <param name="x"></param>
/// <param name="n">The last number in the sum, must be greater than 1</param>
let sumOf x n =
    divide (minus (pown x (add n 1)) 1) (minus x 1)
