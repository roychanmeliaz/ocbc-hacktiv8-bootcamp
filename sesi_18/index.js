// object
const kursi = {
    // properti
    // key: value
    warna: "putih salju",
    bahan: "kain",
    merk: "FSD OCBC",
    jumlahKaki: 40,
    kategori: "gaming",
    harga: 750000,
    bebanMaksimal: 200,
    400: "oke"
}

console.log(kursi)

// akses property
// ========================
// 1: object.property
console.log(kursi.warna)
// 2: object['property']
console.log(kursi['kategori'])
console.log(kursi['400'])
// 3. with var
cariCiri = 'bebanMaksimal'
console.log(kursi[cariCiri])
// ========================

console.log(kursi)

kursi.distribusi = ['Jakarta','Bandung','Surabaya']

console.log(kursi)

kursi.bahan = [
    kursi.bahan,
    'titanium'
]

console.log(kursi)

delete kursi.kategori

console.log(kursi)

// arr
// const kursiArray = [
//     'putih salju',
//     'kain',
//     40,
//     'gaming'
// ]

function getValue(obj,key) {
    return obj[key]
}

const getValueAnother = function (obj,key) {
    return obj[key]
}
const getValueArrowFunction = (obj, key) => obj[key]

console.log(getValue(kursi,'harga'))
console.log(getValueAnother(kursi,'harga'))
console.log(getValueArrowFunction(kursi,'harga'))
