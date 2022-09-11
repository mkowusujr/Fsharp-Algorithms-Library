module Algorithms.Arithmetic.Powers.Tests

open Xunit
open Algorithms.Arithmetic.Powers

[<Fact>]
let ``raiseToPower b n where b is 2 and n is 8 `` () = Assert.Equal(256, raiseToPower 2 8)

[<Fact>]
let ``raiseToPowerRec b n where b is 2 and n is 8 `` () = Assert.Equal(256, raiseToPowerRec 2 8)
