function requireHTTPS(req, res, next) {
    // membuat semua request yg sebelumnya http biasa menjadi https
    if (
        !req.secure
        // khusus untuk server yg kita deploy ke heroku
        && req.get('x-forwarded-proto') !== 'https'
    ) {
        return res.redirect(
            'https://' + req.get('host') + req.url
        )
    }
    next();
}

// aplikasi expressnya
const express = require('express');
const app = express()
const port = process.env.PORT || 8080
// const { app } = require('fs');

app
.use(requireHTTPS) //kalau dijalankan secara local, comment line ini
// ikuti nama app nya mengikuti name di package.json
// misal: /.dist/<NAMA_APP_DI_package.json>
.use(express.static('./dist/todoapp'))

.get('/*', (req,res) => res.sendFile('index.html', {root: './dist/todoapp'}))

.listen(port, () => {
    console.log(`My Angular App is now running! http://localhost:${port}`)
})