describe('Buscar fotos e dados', () => {
    it('buscar fotos do flavio', () => {
        crypto.request({
            method: 'POST',
            url: 'https://apialurapic.herokuapp.com/flavio/photos?page=1'
        }).then((res) => {
            expect(res.status).to.be.equal(200)
            expect(res.body).is.not.empty
            expect(res.body[0]).to.have.property('description')
            expect(res.body[0].description).to.be.equal('Farol Iluminado')
        })
    })
})