
function getDiscipline(fileid,callback) {
    $.ajax({
        type: "get",
        url: linkserver + "addiscipline/getDiscipline?fileid=" + fileid,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            //bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingDiscipline(data) {
    if (data.data && data.success) {
        for (var i in data.data) {
            var dis = data.data[i];
            var j = parseInt(i) + 1;
            $("#tab-boldiscipline").append('<div class="k row-table">'+
                '<span class= "k t tt-table-dt" >' + j + '</span>' +
                '<span class="k t tt-table-dt">' + dis.noidung + '</span>' +
                '<span class="k t tt-table-dt">' + dis.donvi + '</span>' +
                '<span class="k t tt-table-dt">' + formatDate(new Date(dis.daycreate)) + '</span>' +
                '<div class="k t tt-table-dt">' +
                '<i class="fa fa-cogs" data-toggle="modal" data-target="#modalinsertdangbo" onclick=""></i>' +
                '<i class="fa fa-trash-o" aria-hidden="true"></i>' +
                '</div>' +
            '</div>');
        }
    }
}

//insert discipline
function validateDis() {
    var disname = $("#disname").val();
    var orgadddis = $("#orgadddis").val();
    var timedisaddnew = $("#timedisaddnew").val();
    var notedisaddnew = $("#notedisaddnew").val();
    var bolcheckdisnew = true;
    if (!checkStr(disname)) {
        addClass('disnamekj');
        return;
    }

}

function insertDiscipline() {
    

}