module Algorithms.Arithmetic.Sums

open Algorithms.Arithmetic.BasicArithmetic

let sumTo n = divide (mult n (add n 1)) 2

let sumOf x n =
    divide (minus (pown x (add n 1)) 1) (minus x 1)
