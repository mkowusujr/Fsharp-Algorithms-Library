module Algorithms.Searching.BinarySearch.Tests

open Xunit
open Algorithms.Searching.BinarySearch

[<Fact>]
let ```searchSlice [|1;2;3;4;5|] 4`` () =
    let original: int array = [|1;2;3;4;5|]
    let value = 4
    Assert.True(searchSlice original value)