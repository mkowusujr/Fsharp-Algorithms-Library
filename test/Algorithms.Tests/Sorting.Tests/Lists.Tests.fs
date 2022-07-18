module Algorithms.Sorting.Lists.Tests

open Xunit
open Algorithms.Sorting.Lists

[<Fact>]
let ``can makeRandList`` () =
    let c = 5
    let l = makeRandList c
    Assert.Equal(c, l.Length)