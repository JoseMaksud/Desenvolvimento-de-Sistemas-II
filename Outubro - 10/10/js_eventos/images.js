// random gera um numero de  a 1, ex: 0.5
// floor arredonda para baixo
// *5 vai gerar um numerto ate 5.99, com o floor, arredonda para 5

var num = Math.floor(Math.random() * 5);
var imagens = [
    'img/1.jpg',
    'img/2.jpg',
    'img/3.jpg',
    'img/4.jpg',
    'img/5.jpg',
];

var visualizar = imagens[num];
document.write('<h1> === APERTE F5 === </h1>');
document.write(`<img src="${visualizar}">`);