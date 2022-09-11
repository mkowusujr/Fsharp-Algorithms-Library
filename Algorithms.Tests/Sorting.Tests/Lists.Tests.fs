module Algorithms.Sorting.Lists.Tests

open Xunit
open Algorithms.Sorting.Lists

[<Fact>]
let ``can randList`` () =
    let count = 5
    let min = 1
    let max = 100
    let l = randList count min max
    Assert.Equal(count, l.Length)

[<Fact>]
let ``can make orderedList`` () =
    let x1 = 1
    let y1 = 10
    let l1 = orderedList x1 y1
    for i in 0 .. (l1.Length - 2 ) do
        Assert.True(l1[i] <= l1[i+1])
    let x2 = -10
    let y2 = 10
    let l2 = orderedList x2 y2
    for i in 0 .. (l2.Length - 2 ) do
        Assert.True(l2[i] <= l2[i+1])

[<Fact>]
let ``can make reverseOrderdList`` () =
    let x1 = 1
    let y1 = 10
    let l1 = reverseOrderdList x1 y1
    for i in 0 .. (l1.Length - 2 ) do
        Assert.True(l1[i] >= l1[i+1])
    let x2 = -10
    let y2 = 10
    let l2 = reverseOrderdList x2 y2
    for i in 0 .. (l2.Length - 2 ) do
        Assert.True(l2[i] <= l2[i+1])