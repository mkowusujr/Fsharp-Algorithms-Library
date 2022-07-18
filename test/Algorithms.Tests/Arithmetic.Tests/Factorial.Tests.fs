module Algorithms.Arithmetic.Factorial.Tests

open Xunit
open Algorithms.Arithmetic.Factorial

[<Fact>]
let ``factorial can find the factorial given an input`` () = 
    let n1 = 0
    let e1 = 1
    Assert.Equal(e1, factorial n1)
    let n2 = 1
    let e2 = 1
    Assert.Equal(e2, factorial n2)
    let n3 = 2
    let e3 = 2
    Assert.Equal(e3, factorial n3)
    let n4 = 3
    let e4 = 6
    Assert.Equal(e4, factorial n4)
    let n5 = 4
    let e5 = 24
    Assert.Equal(e5, factorial n5)
    let n6 = 5
    let e6 = 120
    Assert.Equal(e6, factorial n6)
    let n7 = 6
    let e7 = 720
    Assert.Equal(e7, factorial n7)