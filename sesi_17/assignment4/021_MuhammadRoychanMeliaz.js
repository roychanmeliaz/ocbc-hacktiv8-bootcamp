// a=10
// b=2
a=process.argv[2]
b=process.argv[3]
if (a==undefined || b==undefined) {
    console.log("Usage:\n\tnode program.js {a} {b}\nEx:\n\tnode 021_MuhammadRoychanMeliaz.js 10 2")
} else {
    console.log("Sum:",a+b)
    console.log("Difference:",a-b)
    console.log("Product:",a*b)
    console.log("Quotient:",a/b)
    console.log("Remainder:",a%b)
    console.log("Value of num1 after increment:",++a)
    console.log("Value of num2 after decrement:",--b)    
}