function drawOnCanvas(canvasId) {

    var canvas = document.getElementById(canvasId);
    var context = canvas.getContext("2d");

    context.clearRect(0, 0, canvas.clientWidth, canvas.clientHeight);

    drawLorem(context);
    drawIpsum(context);
}

function drawLorem(context) {

    // Letter 'L'
    context.moveTo(100, 50);
    context.lineTo(100, 125);
    context.stroke();
    context.moveTo(100, 125);
    context.lineTo(140, 125);
    context.stroke();

    // Letter 'o'
    context.beginPath();
    context.arc(180, 106, 19, (0 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();

    // Letter 'r'
    context.moveTo(225, 88);
    context.lineTo(225, 125);
    context.stroke();
    context.beginPath();
    context.arc(244, 106, 19, (2 / 2) * Math.PI, (3.5 / 2) * Math.PI);
    context.stroke();

    // Letter 'e'
    context.moveTo(271, 106);
    context.lineTo(309, 106);
    context.stroke();
    context.beginPath();
    context.arc(290, 106, 19, (0.5 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();

    // Letter 'm'
    context.moveTo(320, 88);
    context.lineTo(320, 125);
    context.stroke();
    context.beginPath();
    context.arc(339, 106, 19, (2 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();
    context.moveTo(358, 106);
    context.lineTo(358, 125);
    context.stroke();
    context.beginPath();
    context.arc(377, 106, 19, (2 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();
    context.moveTo(396, 106);
    context.lineTo(396, 125);
    context.stroke();

}

function drawIpsum(context) {

    // Letter 'I'
    context.moveTo(450, 175);
    context.lineTo(450, 250);
    context.stroke();
    context.moveTo(430, 175);
    context.lineTo(470, 175);
    context.stroke();
    context.moveTo(430, 250);
    context.lineTo(470, 250);
    context.stroke();

    // Letter 'p'
    context.moveTo(490, 225);
    context.lineTo(490, 275);
    context.stroke();
    context.beginPath();
    context.arc(509, 231, 19, (0 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();

    // Letter 's'
    context.moveTo(569, 213);
    context.lineTo(560, 213);
    context.stroke();
    context.beginPath();
    context.arc(560, 222, 9, (1 / 2) * Math.PI, (3 / 2) * Math.PI);
    context.stroke();
    context.beginPath();
    context.arc(560, 240, 9, (3 / 2) * Math.PI, (1 / 2) * Math.PI);
    context.stroke();
    context.moveTo(551, 249);
    context.lineTo(560, 249);
    context.stroke();

    // Letter 'u'
    context.moveTo(590, 211);
    context.lineTo(590, 230);
    context.stroke();
    context.beginPath();
    context.arc(609, 230, 19, (0 / 2) * Math.PI, (2 / 2) * Math.PI);
    context.stroke();
    context.moveTo(628, 211);
    context.lineTo(628, 249);
    context.stroke();


    // Letter 'm'
    context.moveTo(650, 211);
    context.lineTo(650, 249);
    context.stroke();
    context.beginPath();
    context.arc(669, 230, 19, (2 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();
    context.moveTo(688, 230);
    context.lineTo(688, 249);
    context.stroke();
    context.beginPath();
    context.arc(707, 230, 19, (2 / 2) * Math.PI, (4 / 2) * Math.PI);
    context.stroke();
    context.moveTo(726, 230);
    context.lineTo(726, 249);
    context.stroke();
}