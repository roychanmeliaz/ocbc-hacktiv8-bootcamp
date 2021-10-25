// string
var greeting ="Greetings,"
let name = "Roy"

// number
const pi =3.14

// boolean
let isPresent = false

// undefined
let address
let phoneNumber = undefined

// print
console.log(greeting, name) //striked word = vscode bug
console.log(isPresent)
console.log(pi)
console.log(address, phoneNumber)

// var vs let
//=========================
// var globally defined
// let is scoped
{
    let message = "Halo"
}
// error
// console.log(message)
//=========================

console.log(typeof greeting)
console.log(typeof isPresent)
console.log(typeof pi)
console.log(typeof phoneNumber)

// var naming convention.
// ========================
// C# PascalCase
// js lowerUpper
// ========================

// deklarasi
// ========================
// pendeklarasian ulang let dilarang (bakal bikin error)
// pendeklarasian ulang var tidak apa-apa
var greeting = "hihi"
console.log(greeting)
// let name = "Meliaz" // err redeclaration
console.log(name)
// ========================

// mathematical operation
// ========================
const pi1 = 3.14
const pi2 = "3.14"
console.log(pi1 + pi2) //output string
console.log(pi1 - pi2) //output number
console.log(pi1 * pi2) //output number
console.log(pi1 / pi2) //output number
console.log(5 - "hello") //output NaN
// % = mod
console.log(5%3)
// ========================

// comparison
// ========================
// === nilai dan tipe data sama
// 5 === 5 -> true
// == nilai sama
// "5" == 5 -> true
// ========================

// weakly typed
let iniNilai = "Michael"
iniNilai = 128
console.log(iniNilai)

// conditional
// ========================
let nilai = 79
if (nilai > 80) {
    console.log('Nilai anda adalah A!')
} else {
    console.log('Anda harus berusaha lagi ya!')
}
// and &&
// or ||
// ========================

// Truthy and Falsy
// ========================
// Truthy -> Semua yang tidak Falsy, [], {}
// Falsy -> false, 0, "", undefined, NaN, Null
// 
// undefined -> undefined falsy
// Null -> object falsy (special primitive)
// ========================

// Iterasi
// ========================
const iterations = 10
let counter = 0
// lebih cocok untuk iterasi yang tidak tentu
while (counter < iterations) {
    console.log(counter)
    counter++
}

// lebih cock untuk iterasi yang nilainya eksak
for (let i=0; i<10; i++) {
    console.log(i)
}
// ========================

// Array
// ========================
const students = [
    'Roychan',
    'Bayu',
    'Ricky',
    'Rara',
    'Etasa',
]
students[0] = 'Roy' // masih bisa di assign
// push
students.push('Nelson', 'Cahyadi') // masih bisa di assign juga
console.log(students)
// pop
students.pop() //pop last index
console.log(students)
// unshift
students.unshift('Febri') // push to first index
console.log(students) 
// shift
students.shift() //pop first index
console.log(students)
// join
const studentsInString = students.join(' ')
console.log(studentsInString)
// split
console.log(studentsInString.split(' '))
console.log("Arif".split(''))
// slice
const numbers2 = [1, 42, 11, 44, 75]
const splice_numbers2 = numbers2.splice(2)
console.log(numbers2,splice_numbers2)
// splice (hapus dari depan) dan motong array lama
console.log(process.argv.splice(1))
// sort
const numbers = [1, 3, 11, 21, 75]
numbers.sort()
console.log(numbers)
const numbers1 = [1, 42, 11, 44, 75]
numbers1.sort((a,b)=>{return a-b}) //mdn sort
console.log(numbers1)
const anArray = [
    'Gusti',
    22,
    true,
    "zz"
]
anArray.sort()
console.log(anArray)

// ========================

