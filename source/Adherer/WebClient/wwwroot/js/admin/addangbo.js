
var bol = true;
function toggeChibo(obj) {
    if (bol) {
        $(".f-chibo").show(400);
        $(obj).removeClass("fa-plus");
        $(obj).addClass("fa-minus");
        bol = false;
    }
    else {
        $(".f-chibo").hide(400);
        $(obj).addClass("fa-plus");
        $(obj).removeClass("fa-minus");
        bol = true;
    }
}