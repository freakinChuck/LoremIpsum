/****************** SinusCanvas JavaScript ******************/
/*
    
    Das SinusCanvas JavaScript file beinhaltet JavaScipt Funktionen, mit welchen das Canvas auf der entsprechenden Seite beschrieben wird.    
    
    Author: Silvio Stappung
    
*/

function drawSinusGraph(canvasId, posDeg) {

    var canvas = document.getElementById(canvasId);
    var context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.clientWidth, canvas.clientHeight);


    var posRad = posDeg * (Math.PI / 180);

    var sin = Math.sin(posRad);
    var cos = Math.cos(posRad);

    var canvasWidth = canvas.clientWidth;
    var canvasHeight = canvas.clientHeight;

    var padding = 20;

    var kreisRadius = ((canvasWidth > canvasHeight ? canvasHeight : canvasWidth) - (2 * padding)) / 2;

    var kreisMittelpunkt = kreisRadius + padding;

    var kreisItemDotX = kreisMittelpunkt + (kreisRadius * cos);
    var kreisItemDoty = kreisMittelpunkt - (kreisRadius * sin);

    zeichneKreis(context, kreisItemDotX, kreisItemDoty, 1, 0, 360);

    // zeichne Einheitskreis
    zeichneKreis(context, kreisMittelpunkt, kreisMittelpunkt, kreisRadius, 0, 360);
    zeichneLinie(context, kreisMittelpunkt, kreisMittelpunkt - kreisRadius, kreisMittelpunkt, kreisMittelpunkt + kreisRadius);
    zeichneLinie(context, kreisMittelpunkt - kreisRadius, kreisMittelpunkt, kreisMittelpunkt + kreisRadius, kreisMittelpunkt);
    zeichneLinie(context, kreisItemDotX, kreisMittelpunkt, kreisItemDotX, kreisItemDoty, 'blue');
    zeichneLinie(context, kreisMittelpunkt, kreisMittelpunkt, kreisItemDotX, kreisItemDoty, 'blue');
    zeichneLinie(context, kreisMittelpunkt, kreisMittelpunkt, kreisItemDotX, kreisMittelpunkt, 'blue');

    zeichnePunkt(context, kreisItemDotX, kreisItemDoty, 5);
    
}

function zeichneKreis(context, xPos, yPos, radius, startDeg, endDeg, color) {
    if (color == undefined) {
        color = 'black';
    }
    context.beginPath();
    context.arc(xPos, yPos, radius, startDeg * (Math.PI / 180), endDeg * (Math.PI / 180));
    context.strokeStyle = color;
    context.stroke();
}
function zeichneLinie(context, xPosStart, yPosStart, xPosEnd, yPosEnd, color) {
    if (color == undefined) {
        color = 'black';
    }

    context.beginPath();
    context.moveTo(xPosStart, yPosStart);
    context.lineTo(xPosEnd, yPosEnd);
    context.strokeStyle = color;
    context.stroke();

}

function zeichnePunkt(context, xPos, yPos, radius, color) {
    if (color == undefined) {
        color = 'black';
    }

    context.beginPath();
    context.arc(xPos, yPos, radius, 0, 360);
    context.strokeStyle = color;
    context.fillStyle = color;
    context.fill();
    context.stroke();

}