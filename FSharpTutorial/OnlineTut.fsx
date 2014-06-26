//function as value
let quadruple x = 
    let double x =
        x*2   
    double(double (x))

quadruple 3

//type annotation: In order to use String.Replace, tell explictly it's string type
let toHackTalk (phrase:string) = 
    phrase.Replace('t', '7')
          .Replace('o', '0')

//bind name to function
let add x y =
    x + y

add 2 3

//function as args - high order function
let chrisTest test = 
    test "Chris"

let isMe x = 
    if x = "Chris" then
        "it is Chris!"
    else
        "it's someone else"

chrisTest isMe

//lambda function Or 'anonymous function' is to Create a small helper function
let addL = (fun x y -> x + y)
addL 2 2

let twoTest test = 
    test 2

twoTest (fun x -> x = 2)  //true
twoTest (fun x -> x < 0)  //false

//finish until here:
//http://www.tryfsharp.org/Learn/getting-started#chaining-functions