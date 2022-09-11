module Algorithms.Sorting.QuickSort.Tests

open Xunit
open Algorithms.Sorting.QuickSort
open Algorithms.Sorting.Lists

[<Fact>]
let ``quick sort on reversed list`` () =
    let originalList: int list = [ 5; 4; 3; 2; 1 ]
    let actualList: int list = qSort originalList
    let expectedList: int list = [ 1; 2; 3; 4; 5 ]
    Assert.Equal<int list>(expectedList, actualList)

[<Fact>]
let ``quick sort on ordered list`` () =
    let originalList: list<int> = [ 1; 2; 3; 4; 5 ]
    let actualList: list<int> = qSort originalList
    let expectedList: int list = [ 1; 2; 3; 4; 5 ]
    Assert.Equal<int list>(expectedList, actualList)

[<Fact>]
let ``quick sort on randomized list`` () =
    let originalList: list<int> = randList 15 1 100
    let actualList: list<int> = qSort originalList

    for i in 0 .. (actualList.Length - 2) do
        Assert.True(actualList[i] <= actualList[i + 1])
