function removeSpaces(text) {
    return text.split(' ').join('')
}
function reverseText(text) {
    return text.split('').reverse().join('')
}
function updateVowels(text) {
    arr = text.split('')
    for (let i=0; i<arr.length; i++) {
        if ("aeiouAEIOU".indexOf(arr[i]) != -1) {
            arr[i] = String.fromCharCode(arr[i].charCodeAt(0) + 1)
        }
    }
    return arr.join('')
}

var password = 'pass word'
var noSpaces = removeSpaces(password)
var reversed = reverseText(noSpaces)
var encryptedPassword = updateVowels(reversed)

console.log(noSpaces)
console.log(reversed)
console.log(encryptedPassword)
