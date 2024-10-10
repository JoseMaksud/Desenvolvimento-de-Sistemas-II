var imagens = [
    'img/1.jpg',
    'img/2.jpg',
    'img/3.jpg',
    'img/4.jpg',
    'img/5.jpg',
];

var banner = document.getElementById("banner");
i = 0;
setInterval(() => {
    banner.src = imagens[i];
    
    i++;

    if (i == 5)
        i = 0;
}, 1000);