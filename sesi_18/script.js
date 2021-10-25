console.log("start js")

// ambil "page title"
// document.getElementsById
let pageTitleElement = document.getElementById('title')
console.log(pageTitleElement)
console.log(pageTitleElement.innerHTML)

// document.getElementsByClassName
let pageBoxElements = document.getElementsByClassName("page-box")
console.log(pageBoxElements)
for (let i=0; i<pageBoxElements.length; i++) {
    const pageBox = pageBoxElements[i]
    console.log(pageBox.innerHTML)
}

// document.getElementsByTagName
let divElements = document.getElementsByTagName("div")
console.log(divElements)
console.log("end js")

// ============================= JQuery
console.log("start jquery")

$(document).ready(function () {

    // # id
    console.log($('#title')) 
    // . class
    console.log($('.page-box'))
    $('#title').click(function () {
        alert('Saya klik page title')
    })

    $('#submitButton').click(function (e){
        e.preventDefault()
        // let username = $('#username').val()
        let username = $('input[name="username"]').val()
        console.log(username)
        alert("Halo "+username+'!')
    })

    // pagebox add class btn-danger
    $('.page-box:first').addClass( "btn-danger" );

})


