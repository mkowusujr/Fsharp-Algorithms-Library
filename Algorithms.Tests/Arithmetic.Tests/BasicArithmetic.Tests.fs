module Algorithms.Arithmetic.BasicArithmetic.Tests

open Xunit
open Algorithms.Arithmetic

[<Fact>]
let `` add x y return the sum`` () =
    Assert.Equal(10, add 3 7)
    Assert.Equal(-2, add -5 3)
    Assert.Equal(7, add 0 7)

[<Fact>]
let `` minus x y return the difference`` () =
    Assert.Equal(3, minus 10 7)
    Assert.Equal(-9, minus -4 5)
    Assert.Equal(-3, minus 7 10)

[<Fact>]
let `` mult x y return the product`` () =
    Assert.Equal(15, mult 3 5)
    Assert.Equal(25, mult 5 5)
    Assert.Equal(9, mult -3 -3)

[<Fact>]
let `` divide x y return the quoient`` () =
    Assert.Equal(3/2, divide 15 10)
    Assert.Equal(1, divide 10 10)