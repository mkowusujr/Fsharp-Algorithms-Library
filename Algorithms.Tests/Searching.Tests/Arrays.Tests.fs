module Algorithms.Searching.Arrays.Tests

open Xunit
open Algorithms.Searching.Arrays

[<Fact>]
let ``` arraySliceRange [| 1;2;3|] 0 1`` () =
    let arrExpect: int array = [| 1; 2 |]
    let arrActual: int array = arraySliceRange [| 1; 2; 3 |] 0 1
    Assert.Equal<int array>(arrExpect, arrActual)

[<Fact>]
let ``` arraySlice [| 1;2;3|] 1`` () =
    let arrExpect: int array = [| 2; 3 |]
    let arrActual: int array = arraySlice [| 1; 2; 3 |] 1
    Assert.Equal<int array>(arrExpect, arrActual)
