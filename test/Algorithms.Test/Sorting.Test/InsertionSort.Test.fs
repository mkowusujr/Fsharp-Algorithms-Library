module Algorithms.Sorting.InsertionSort.Tests

open Xunit
open Algorithms.Sorting

let makeRandList count =
    let rnd = System.Random()
    List.init count (fun _ -> rnd.Next(1, 100))

[<Fact>]
let ``can makeRandList`` () =
    let c = 5
    let l = makeRandList c
    Assert.Equal(c, l.Length)

[<Fact>]
let ``insertion sort on reversed list`` () =
    let l: list<int> = [5;4;3;2;1]
    let a: list<int> = isort l
    for i in 1 .. (a.Length - 2 ) do
        Assert.True(a[i] < a[i+1])

[<Fact>]
let ``insertion sort on ordered list`` () =
    let l: list<int> = [1;2;3;4;5]
    let a: list<int> = isort l
    for i in 1 .. (a.Length - 2 ) do
        Assert.True(a[i] < a[i+1])

[<Fact>]
let ``insertion sort on randomized list`` () =
    let l: list<int> = makeRandList 15
    let a: list<int> = isort l
    for i in 1 .. (a.Length - 2 ) do
        Assert.True(a[i] <= a[i+1])