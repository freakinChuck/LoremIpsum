function loadthemecssfile(url) {
    $('[data-style=dynamic').remove();
    $('head').append($('<link rel="stylesheet" type="text/css" />').attr('href', url).attr('data-style', 'dynamic'));
}

function loadtheme(theme) {
    var themeStyleSheet = '/_Styles/' + theme + '.css';
    loadthemecssfile(themeStyleSheet);
}

var cookieName = 'SelectedTheme';
function readstyle() {

    var content = $.cookie(cookieName);
    if (!content) {
        content = "Main"; //Default Theme
    }
    return content; 

}
function setstyle(theme) {
    var expirationDate = new Date(3000, 12, 31); // nicht erreichbares Jahr
    $.cookie(cookieName, theme, { expires: expirationDate });
    loadtheme(theme);
}