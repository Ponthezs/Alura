describe('Login e registro de usuarios alura pic', () => {

    beforeEach(() => {
        cy.visit('https://alura-fotos.herokuapp.com/#/home')
    })
    it ('verifica mensagens validacao', () => {
       cy.contains('a', 'Register now').click();
       cy.contains('button', 'Register').click();
       cy.contains('ap-vmessage', 'Email is required!').should('be.visible');
       cy.contains('button', 'Register').click();
       cy.contains('ap-vmessage', 'Full name is required!').should('be.visible');
       cy.contains('ap-vmessage', 'User name is required!').should('be.visible');
       cy.contains('ap-vmessage', 'Password is required!').should('be.visible');
    })

    it ('verifica mensagens de email invalido', () => {
        cy.contains('a', 'Register now').click();
        cy.contains('button', 'Register').click();
        cy.get('input[formcontrolname="email"]').type('felipe')
        cy.contains('ap-vmessage', 'Invalid e-mail').should('be.visible');
     })

     it ('verifica mensagens de senha com menos de 8 caracteres', () => {
        cy.contains('a', 'Register now').click();
        cy.contains('button', 'Register').click();
        cy.get('input[formcontrolname="password"]').type('542')
        cy.contains('button', 'Register').click();
        cy.contains('ap-vmessage', 'Mininum length is 8').should('be.visible');
     })

     it ('verifica mensagens de nome completo com menos de 2 caracteres', () => {
        cy.contains('a', 'Register now').click();
        cy.contains('button', 'Register').click();
        cy.get('input[formcontrolname="fullName"]').type('d')
        cy.contains('button', 'Register').click();
        cy.contains('ap-vmessage', 'Mininum length is 2').should('be.visible');
     })

     it ('verifica mensagens de nome com letras minusculas', () => {
        cy.contains('a', 'Register now').click();
        cy.contains('button', 'Register').click();
        cy.get('input[formcontrolname="userName"]').type('FELIPE')
        cy.contains('button', 'Register').click();
        cy.contains('ap-vmessage', 'Must be lower case').should('be.visible');
     })


})