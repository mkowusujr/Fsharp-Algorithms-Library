module Algorithms.Arithmetic.Sums.Tests

open Xunit
open Algorithms.Arithmetic

[<Fact>]
let ``sumTo n where n is 4 return 10`` () = Assert.Equal(10, sumTo 4) //expected, actual

[<Fact>]
let ``sumOf x n where x is 2 and n is 3 return 15`` () = Assert.Equal(15, sumOf 2 3)
