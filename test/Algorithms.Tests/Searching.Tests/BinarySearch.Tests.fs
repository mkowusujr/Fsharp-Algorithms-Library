module Algorithms.Searching.BinarySearch.Tests

open Xunit
open Algorithms.Searching.BinarySearch
[<Fact>]
let ```searchSlice [| |] 4`` () =
    let original: int array = Array.empty
    let value = 4
    Assert.False(searchSlice original value)

[<Fact>]
let ```searchSlice [|1|] 1`` () =
    let original: int array = [|1|]
    let value = 1
    Assert.True(searchSlice original value)

[<Fact>]
let ```searchSlice [|1;2|] 2`` () =
    let original: int array = [|1;2|]
    let value = 2
    Assert.True(searchSlice original value)   

[<Fact>]
let ```searchSlice [|1;2;3;4;5|] 4`` () =
    let original: int array = [|1;2;3;4;5|]
    let value = 4
    Assert.True(searchSlice original value)