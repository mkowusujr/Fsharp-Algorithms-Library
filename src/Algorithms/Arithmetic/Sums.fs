module Algorithms.Arithmetic.Sums

let sumTo n =
    ( n ( n + 1 ) ) / 2

let sumOf x n =
    ( ( x**(n + 1) ) - 1 ) / ( x - 1 )