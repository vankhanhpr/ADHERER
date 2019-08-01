var linkserver = "https://localhost:44343/api/";
var linkfileuser = "https://localhost:44343/images/user/";

function formatDate(date) {
    var hours = date.getHours();
    var minutes = date.getMinutes();
    var ampm = hours >= 12 ? 'pm' : 'am';
    hours = hours % 12;
    hours = hours ? hours : 12; // the hour '0' should be '12'
    minutes = minutes < 10 ? '0' + minutes : minutes;
    var strTime = hours + ':' + minutes + ' ' + ampm;
    var month = (date.getMonth() + 1) < 10 ? '0' + (date.getMonth() + 1) : (date.getMonth() + 1);
    var day = date.getDate() < 10 ? '0' + date.getDate() : date.getDate();
    return day + "/" + month + "/" + date.getFullYear();
}
function showLoading() {
    $("body").append('<div class="lds-ring"><div></div><div></div><div></div><div></div></div>');
}
function destroyLoading() {
    $(".lds-ring").hide();
}