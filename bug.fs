let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y <- x - y
    x

let z = add x y
printf "%d %d %d" x y z