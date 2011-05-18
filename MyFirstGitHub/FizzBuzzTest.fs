module FizzBuzzTest

open NUnit.Framework
open FizzBuzzMain

[<Test>]
let test_fizzbuzz_3を適用したらFizzって返す () =
    Assert.That ("Fizz", Is.EqualTo (fizzbuzz 3));;

[<Test>]
let test_fizzbuzz_5を適用したらBuzzって返す () =
    Assert.That ("Buzz", Is.EqualTo (fizzbuzz 5));;

[<Test>]
let test_fizzbuzz_4を適用したら4って返す () =
    Assert.That ("4", Is.EqualTo (fizzbuzz 4));;

[<Test>]
let test_fizzbuzz_6を適用したらFizzって返す () =
    Assert.That ("Fizz", Is.EqualTo (fizzbuzz 6));;