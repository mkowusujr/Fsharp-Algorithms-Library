module Algorithms.Arithmetic.Sums

open Algorithms.Arithmetic.BasicArithmetic

/// <summary>The sum of numbers from one to n</summary>
/// <param name="n">The last number in the sum, must be greater than 1</param>
let sumTo n = divide (multiply n (add n 1)) 2

/// <summary>The sum of x to the n</summary>
/// <param name="x">The base number</param>
/// <param name="n">The exponent</param>
let sumOf x n =
    divide (subtract (pown x (add n 1)) 1) (subtract x 1)
