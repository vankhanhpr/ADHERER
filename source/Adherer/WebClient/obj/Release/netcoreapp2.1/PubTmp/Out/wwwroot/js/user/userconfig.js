//var linkserver = "https://localhost:44343/api/";
//var linkfileuser = "https://localhost:44343/images/user/";
//var linkfiledownload = "https://localhost:44343/files/";
var linkserver = "https://10.70.38.62:2001/api/";
var linkfileuser = "https://10.70.38.62:2001/images/user/";
var linkfiledownload = "https://10.70.38.62:2001/files/";


function getTokenByLocal() {
    var token = strToObj(window.localStorage.getItem('token_session'));
    return token;
}
function strToObj(str) {//convert string to object
    var obj = {};
    if (str && typeof str === 'string') {
        var objStr = str.match(/\{(.)+\}/g);
        eval("obj =" + objStr);
    }
    return obj;
}