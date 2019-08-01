
function getFamilies(fileid,callback) {
    $.ajax({
        type: "get",
        url: linkserver + "adfamily/getFamilies?fileid=" + fileid,
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
function bindigFamilies(data) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var fml = data.data[i];
            var j = parseInt(i) + 1;
            $("#tab-family").append('<div class="k row-table">' +
                '<span class= "k t tt-table-dt" >'+j+'</span >' +
                '<span class="k t tt-table-dt">'+fml.quanhe+'</span>' +
                '<span class="k t tt-table-dt">'+fml.name+'</span>' +
                '<span class="k t tt-table-dt">'+fml.nghenghiep+'</span>' +
                '<div class="k t tt-table-dt">' +
                '<i class="fa fa-cogs" data-toggle="modal" data-target="#modalupdatefamily"></i>' +
                '<i class="fa fa-trash-o" aria-hidden="true"></i>' +
                '</div>' +
                '</div>');
        }
    }
}

function validateFormIsFml() {
    var namefml = $("#namefml").val();
    //var qhe = $("#sl-fml-qh").children("option:selected").text();
    var fmlwork = $("#fmlwork").val();
    var fmlchinhtri = $("#fmlchinhtri").val();
    var bol = true;
    if (!checkStr(namefml)) {
        addClass('namefml');
        $('.err-validate').show();
        bol = false;
    }
    else {
        removeClass('namefml');
    }
    if (!checkStr(fmlwork)) {
        addClass('fmlwork');
        $('.err-validate').show();
        bol = false;
    }
    else {
        removeClass('fmlwork');
    }
    if (!checkStr(fmlchinhtri)) {
        addClass('fmlchinhtri');
        $('.err-validate').show();
        bol = false;
    }
    else {
        removeClass('fmlchinhtri');
    }

    if (!bol) {
        return;
    }
    var fml = {
        'fileid': fileidmain,
        'quanhe': $("#sl-fml-qh option:selected").text(),
        'nghenghiep': fmlwork,
        'hoancanhkinhte': '',
        'lichsuchinhtri': fmlchinhtri,
        'name': namefml,
        'birthday': $("#fml-bd").val(),
    }
    insertFml(fml);
}
var bisfml = true;
function insertFml(data) {
    if (bisfml) {
        bisfml = false;
        $.ajax({
            url: linkserver + "adfamily/insertFamily",
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data),
            async: false,
            processData: false,
            contentType: "application/json",
            error: function (err) {
                bisfml = true;
                bootbox.alert({
                    message: "Error :" + err.message
                });
            },
            success: function (data) {
                bisfml = true;
                if (data.success) {
                    $('#modaladdfamily').modal('toggle');
                    bootbox.alert({
                        message: "Thêm thông tin thành công!",
                        callback: function () {
                            //getDangBo(bindingDangBo);
                        }
                    })
                }
                else {
                    bootbox.alert(data.message);
                }
            }
        });
    }
}


//date picker
$(document).ready(function () {
    $('#datepicker-fml').datetimepicker({
        format: 'DD/MM/YYYY',
        extraFormats: false,
        stepping: 1,
        minDate: false,
        maxDate: false,
        useCurrent: true,
        collapse: true,
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
        icons: {
            time: 'glyphicon glyphicon-time',
            date: 'glyphicon glyphicon-calendar',
            up: 'glyphicon glyphicon-chevron-up',
            down: 'glyphicon glyphicon-chevron-down',
            previous: 'glyphicon glyphicon-chevron-left',
            next: 'glyphicon glyphicon-chevron-right',
            today: 'glyphicon glyphicon-screenshot',
            clear: 'glyphicon glyphicon-trash'
        },
        useStrict: false,
        sideBySide: false,
        daysOfWeekDisabled: [],
        calendarWeeks: false,
        viewMode: 'days',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});
