﻿
function toggeChibo(obj) {
    var y = obj.className;
    if (y == "fa fa-plus") {//kiem tra dang dong
        var x = $(obj).parent().parent();
        var y = x.find(".f-chibo");
        $(y).show(400);
        $(obj).removeClass("fa-plus");
        $(obj).addClass("fa-minus");
        bol = false;
    }
    else {//da ma ra
        var x = $(obj).parent().parent();
        var y = x.find(".f-chibo");
        $(y).hide(400);
        $(obj).addClass("fa-plus");
        $(obj).removeClass("fa-minus");
        bol = true;
    }
}
var dbid = -1;
var truthuoc = 0;
var truthuocaddnew = 0;
var active = 0;
getDangBo(bindingDangBo);
//get dang bo
function getDangBo(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "addangbo/getalldangbo",
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingDangBo(data) {
    if (data.success && data.data.length > 0) {
        $(".row-table").remove();
        for (var i in data.data) {
            var item = data.data[i];
            var view = "";
            if (item.chibo.length > 0) {
                for (var j in item.chibo) {
                    var cb = item.chibo[j];
                    view += '<span class="k t t-name-chibo">' + cb.tencb + '</span>';
                }
            }
            var db = item.db;
            $("#f-item-db").append('<div class="k row-table">' +
                '<span class="k t tt-table-dt">' + db.tendb + '</span >' +
                '<span class="k t tt-table-dt">' + formatDate(new Date(db.ngaythanhlap)) + '</span>' +
                '<span class="k t tt-table-dt">' + (db.active == true ? 'Hoạt động' : 'Khóa') + '</span>' +
                '<div class="k t tt-table-dt">' +
                '<i class="fa fa-cogs" data-toggle="modal" data-target="#modalinsertdangbo" onclick="showTabEditDB(' + db.dbid + ')"></i>' +
                '<i class="fa fa-trash-o" aria-hidden="true"></i>' +
                '<i class="fa fa-plus" aria-hidden="true" onclick="toggeChibo(this)"></i>' +
                '</div>' +
                '<div class="k f-chibo" style="display:none">' +
                view +
                '</div>' +
                '</div>');
        }
    }
}
//edit dangbo
function showTabEditDB(id) {
    cleanFormEdit();
    getDangBoNotAttached(id);

}
function getDetailDangBo(id) {
    $.ajax({
        type: "get",
        url: linkserver + "addangbo/getDangBoById?id=" + id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            if (data.success && data.data != null) {
                dbid = data.data.dbid;
                $("#ip-name-db").val(data.data.tendb);
                $("#day-create-db").val(formatDate(new Date(data.data.ngaythanhlap)));
                $("#sl-db-att option[value='" + data.data.tructhuoc + "']").prop("selected", true);
                $("#sl-db-active option[value='" + data.data.active + "']").prop("selected", true);
            }
        }
    });
}
//clean from edit dangbo
function cleanFormEdit() {
    $("#ip-name-db").val("");
}
//get dangno not attached
function getDangBoNotAttached(id) {
    $.ajax({
        type: "get",
        url: linkserver + "addangbo/getDangBoNotAttached?id=" + id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            //bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            if (data.success) {
                $("#sl-db-att option").remove();
                $("#sl-db-att").append('<option value="0">Không trực thuộc</option>');
                for (var i in data.data) {
                    var item = data.data[i];
                    $("#sl-db-att").append('<option value=' + item.dbid + '>' + item.tendb + '</option>');
                }

            }
            getDetailDangBo(id);
        }
    });
}
//show dangbo to select insert
function binddingDangBoToSl(data) {
    if (data.success) {
        $("#sl-db-att-addnew option").remove();
        $("#sl-db-att-addnew").append('<option value="0">Không trực thuộc</option>');
        for (var i in data.data) {
            var item = data.data[i].db;
            $("#sl-db-att-addnew").append('<option value=' + item.dbid + '>' + item.tendb + '</option>');
        }
    }
}
//update infor dangbo
function updateDangBo() {
    var bol = true;
    var data = {
        'dbid': dbid,
        'tendb': $("#ip-name-db").val(),
        'tructhuoc': parseInt(truthuoc),
        'active': parseInt(active),
        'ngaythanhlap': $("#day-create-db").val()
    };
    if (bol) {
        bol = false;
        $.ajax({
            url: linkserver + "addangbo/updateDangBo",
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data),
            async: false,
            processData: false,
            contentType: "application/json",
            error: function (err) {
                bootbox.alert({
                    message: "Error :" + err.message
                });
            },
            success: function (data) {
                if (data.success) {
                    $('#modaladddangbo').modal('toggle');
                    bootbox.alert({
                        message: "Cập nhật thông tin thành công!",
                        callback: function () {
                            getDangBo(bindingDangBo);
                        }
                    })
                }
                else {
                    bootbox.alert("Có lỗi xảy ra vui lòng kiểm tra lại thông tin!");
                }
            }
        });
    }
}

//onchange truthuoc,active
$('#sl-db-att').on('change', function () {
    truthuoc = this.value;
});

$('#sl-db-att-addnew').on('change', function () {
    truthuocaddnew = this.value;
});

$('#sl-db-active').on('change', function () {
    active = this.value;
});

//datetime picker
$(document).ready(function () {
    $('#datepicker ,#datepicker-is').datetimepicker({
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

//insert dang bo
function insertDangbo() {
    var bol = true;
    var data = {
        'tendb': $("#name-db-addnew").val(),
        'tructhuoc': parseInt(truthuocaddnew),
        'active': 0,
        'ngaythanhlap': $("#day-create-db").val()
    };
    if (bol) {
        bol = false;
        $.ajax({
            url: linkserver + "addangbo/insertDangBo",
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data),
            async: false,
            processData: false,
            contentType: "application/json",
            error: function (err) {
                bootbox.alert({
                    message: "Error :" + err.message
                });
            },
            success: function (data) {
                if (data.success) {
                    $('#modaladddangbo').modal('toggle');
                    bootbox.alert({
                        message: "Thêm Đảng bộ thành công!",
                        callback: function () {
                            getDangBo(bindingDangBo);
                        }
                    });
                }
                else {
                    bootbox.alert("Có lỗi xảy ra vui lòng kiểm tra lại thông tin!");
                }
            }
        });
    }
}
