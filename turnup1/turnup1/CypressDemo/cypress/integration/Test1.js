describe('My Frist Test Scenerios',() => {
  it('My first test case', () => {
    //test step
    cy.visit("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

    //input username
    cy.get('#UserName').type('hari');

    //input password
    cy.get('#Password').type('123123');

    //click login button
    cy.get('.btn').click();

    //assertion
    cy.get('[style="font-size:13px"] > :nth-child(1) > a').should('have.text', 'Dashboard')

  })
})
