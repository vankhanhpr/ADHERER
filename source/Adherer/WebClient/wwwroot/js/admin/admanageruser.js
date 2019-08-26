var token = getTokenByLocal().token;

$("#sl-chibo").on('change', function () {
    getArmorial(bindingArmorial, parseInt(this.value));
});
$("#sl-dangbo").on('change', function () {
    getChiBoByDbId(parseInt(this.value), bindingChiBo);
});
function showTab(tab) {
    $(".body-item").hide();
    $("#" + tab).show();
}
//getArmorial(bindingArmorial);
function getArmorial(callback, id) {
    $.ajax({
        type: "get",
        url: linkserver + "aduser/getArmorial?cbid=" + id,
        data: null,
        headers: { 'authorization': `Bearer ${token}` },
        dataType: 'json',
        contentType: "application/json",
        statusCode: {
            401: function () {
                window.location.href = "/login";
            }
        },
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingArmorial(data) {
    if (data.success && data.data) {
        $(".child-form-user").remove();
        for (var i in data.data) {
            var item = data.data[i];
            var j = parseInt(i) + 1;
            $("#form-armorial").append('<div class="k child-form-user">' +
                '<span class= "k t stt" >' + j + '</span >' +
                '<div class="k t body-user">' +
                '<span class="k t name-user">' + item.name + '</span>' +
                '<span class="k t note-day">Ngày vào Đảng:</span>' +
                '<span class="k t note-day">' + formatDate(new Date(item.ngayvaodang)) + '</span>' +
                '<progress class="k t progress-bar" id="file" data-label="' + item.year + ' năm tuổi Đảng" max="60" value="' + item.year + '"> 70% </progress>' +
                '</div>' +
                '</div>');
        }
    }
}
function getChiBoByDbId(id, callback) {
    $.ajax({
        type: "get",
        url: linkserver + "adchibo/getChiBoByDb?id=" + id,
        data: null,
        headers: { 'authorization': `Bearer ${token}` },
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
getDangBo(bindingDangBo);
function getDangBo(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "addangbo/getalldangbo",
        data: null,
        headers: { 'authorization': `Bearer ${token}` },
        dataType: 'json',
        contentType: "application/json",
        statusCode: {
            401: function () {
                window.location.href = "/login";
            }
        },
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingDangBo(data) {
    if (data.success && data.data) {
        $("#sl-dangbo option").remove();
        for (var i in data.data) {
            var item = data.data[i].db;
            $("#sl-dangbo").append('<option value=' + item.dbid + '>' + item.tendb + '</option>');
        }
        if (data.data[0]) {
            getChiBoByDbId(data.data[0].db.dbid, bindingChiBo);
        }
    }
}
function bindingChiBo(data) {
    if (data.success && data.data) {
        $("#sl-chibo option").remove();
        for (var i in data.data) {
            var item = data.data[i];
            $("#sl-chibo").append('<option value=' + item.cbid + '>' + item.tencb + '</option>');
        }
        if (data.data[0]) {
            getArmorial(bindingArmorial, parseInt(data.data[0].cbid));
        }
    }
}

function getTitle(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "adtitle/getAllTitle",
        data: null,
        headers: { 'authorization': `Bearer ${token}` },
        dataType: 'json',
        contentType: "application/json",
        statusCode: {
            401: function () {
                window.location.href = "/login";
            }
        },
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingTitle(data) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var item = data.data[i];
            $("#sl-title").append('<option value="' + item.titleid + '">' + item.nametitle + '</option>');
        }
    }
}

//datetime picker
$(document).ready(function () {
    $('#datepicker-daytochibo').datetimepicker({
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
        viewMode: 'years',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});

function validateForm() {
    var madv = $("#ip-madv").val();
    var oldadress = $("#adress-on-bussiness").val();
    var daytogo = $("#day-to-go").val();
    var title = parseInt($("#sl-title").children("option:selected").val());
    var pass = $("#ip-pass").val();
    var confilmpass = $("#ip-cf-pass").val();

    var checkinsert = true;
    if (madv.trim() == '') {
        checkinsert = false;
        addClass('ip-madv');
    }
    else {
        removeClass('ip-madv');
    }
    if (oldadress.trim() == '') {
        checkinsert = false;
        addClass('adress-on-bussiness');
    }
    else {
        removeClass('adress-on-bussiness');
    }
    if (pass !== confilmpass || pass.length < 6) {
        addClass('ip-pass');
        addClass('ip-cf-pass');
        checkinsert = false;
    }
    else {
        removeClass('ip-pass');
        removeClass('ip-cf-pass');
    }
    if (!checkinsert) {
        $("#err-validate").show();
        return;
    }
    else {
        $("#err-validate").hide();
    }
    var data = {
        'madv': madv.trim(),
        'cbid': parseInt($("#sl-chibo").children("option:selected").val()),
        'ngaydenchibo': daytogo,
        'roleid': 1,
        'titleid': title,
        'active': 0,
        'password': pass.trim(),
        'lydoden': 1,
        'noisinhhoatcu': oldadress.trim()
    };
    insertUser(data);
}

var bol = true;
function insertUser(data) {
    if (bol) {
        bol = false;
        $.ajax({
            url: linkserver + "aduser/insertUser",
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data),
            headers: { 'authorization': `Bearer ${token}` },
            async: false,
            processData: false,
            contentType: "application/json",
            error: function (err) {
                bol = true;
                bootbox.alert({
                    message: "Error :" + err.message
                });
            },
            success: function (data) {
                bol = true;
                if (data.success) {
                    $('#modalinsertdangvien').modal('toggle');
                    bootbox.alert({
                        message: "Thêm mới Đảng viên thành công!",
                        callback: function () {
                            emptyForm();
                            page = 0;
                            window.location.href = '/admin/manageuser';
                        }
                    });
                }
                else {
                     emptyForm();
                    $('#modalinsertdangvien').modal('toggle');
                    bootbox.alert(data.message);
                }
            }
        });
    }
}

function emptyForm() {
    $("#ip-madv").val('');
    $("#adress-on-bussiness").val('');
    $("#ip-pass").val('');
    $("#ip-cf-pass").val('');
}
function addClass(obj) {
    $("#" + obj).addClass("err-ip");
}
function removeClass(obj) {
    $("#" + obj).removeClass("err-ip");
}