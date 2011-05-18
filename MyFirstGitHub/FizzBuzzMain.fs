// Learn more about F# at http://fsharp.net

module FizzBuzzMain

let fizzbuzz num =
    if num <= 0 then num.ToString ()
    elif num % 15 = 0 then "FizzBuzz"
    elif num % 3 = 0 then "Fizz"
    elif num % 5 = 0 then "Buzz"
    else num.ToString ();;