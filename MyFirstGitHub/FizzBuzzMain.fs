// Learn more about F# at http://fsharp.net

module FizzBuzzMain

let fizzbuzz num =
    if num % 3 = 0 then "Fizz"
    elif num % 5 = 0 then "Buzz"
    else num.ToString ();;