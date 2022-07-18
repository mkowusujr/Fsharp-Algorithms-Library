module Algorithms.Sorting.Test

open Xunit

open Algorithms.Sorting

[<Fact>]
let ``insertion sort on [4;3;2;1] yield [1;2;3;4]`` () =
    let l: list<int> = [4;3;2;1]
    let expected: list<int> = [1;2;3;4]
    let actualList: list<int> = Algorithms.Sorting.isort(l)
    for i in 1 .. (actualList.Lengh - 2 )do
        Assert.True(actualList[i] < actualList[i+1])
    // Assert.Equal (isAscending actualList, true)
    // CollectionAssert.
    // Assert.Collection(actualList).Equals(expected)