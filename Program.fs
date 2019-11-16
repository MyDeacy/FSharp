open System

type User() = 
    class
        [<DefaultValue>] val mutable name : String
        [<DefaultValue>] val mutable age  : int

        member this.Speak = printf "You >> ' I am %s %i years old! '" this.name this.age

        member this.Name = this.name
        member this.Age = this.age
        member this.setName name = this.name <- name
        member this.setAge age = this.age <- age
    end;;
let userObj = new User();;
try
    printf "What is your name\n ->"
    let mutable line = stdin.ReadLine()
    printf "Hello, %s\n" line
    userObj.setName line
    printf "How old are you？\n -> "
    line <- stdin.ReadLine()
    let age = int line
    userObj.setAge age
    userObj.Speak
with
    :? System.FormatException
        -> printfn "You are not human"

