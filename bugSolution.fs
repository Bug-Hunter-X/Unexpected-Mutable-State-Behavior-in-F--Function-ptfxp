let x = 10
let y = 20

let add x y = 
    let newX = x + y
    let newY = newX - y
    (newX, newY)

let (z, w) = add x y
printf "%d %d %d %d" x y z w