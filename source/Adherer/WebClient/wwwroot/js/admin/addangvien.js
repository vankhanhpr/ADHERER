
var bolft = true;
var cbid = 0;
var role = 1;
var titleid = 0;
var page = 0;
var pagesize = 10;
getUser(bindingUser, page, pagesize)

$('#sl-chb-addnew').on('change', function () {
    cbid = parseInt(this.value);
});
$('#sl-role-addnew').on('change', function () {
    role = parseInt(this.value);
});
$('#sl-title-addnew').on('change', function () {
    titleid = parseInt(this.value);
});

function showTabFilter() {
    if (bolft) {
        bolft = false;
        $(".tab-filter").show(300);
        $(".ic-show-ft").toggleClass("down");
    }
    else {
        bolft = true;
        $(".tab-filter").hide(300);
        $(".ic-show-ft").toggleClass("down");

    }
}

//datetime picker
$(document).ready(function () {
    $('#datepicker-addnew, #datepicker-update').datetimepicker({
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

//get all users
function getUser(callback, page, pagesize) {
    $.ajax({
        type: "get",
        url: linkserver + "aduser/getalluser?page=" + page + "&&pagesize=" + pagesize + "",
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
function bindingUser(data) {
    if (data.success && data.data.length > 0) {
        $(".item-dv").remove();
        for (var i in data.data) {
            var user = data.data[i].user;
            var file = data.data[i].file;
            var view = '<div class="k item-dv">' +
                '<div class="k img-avt-dv" ></div >' +
                '<div class="k f-name">' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-user-circle-o font-ic" aria-hidden="true"></i> ' + (file && file.hotendangdung != null ? file.hotendangdung:'' ) + '' +
                '</span>' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-birthday-cake font-ic" aria-hidden="true"></i> ' + (file && file.ngaythangnamsinh != null ? formatDate(file.ngaythangnamsinh): '')+'' +
                '</span>' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-phone-square font-ic" aria-hidden="true"></i> ' + (file && file.sdt != null ? file.sdt : '')+'' +
                '</span>' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-envelope-o font-ic" aria-hidden="true"></i> ' + (file && file.email != null ? file.email : '')+'' +
                '</span>' +
                '</div>' +
                '<div class="k f-name">' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-id-card-o font-ic" aria-hidden="true"></i>' + user.madv + '' +
                '</span>' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-calendar-plus-o font-ic" aria - hidden="true" ></i > '+user.ngaydenchibo+'' +
                '</span>' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-users font-ic" aria-hidden="true"></i>Phòng giải pháp' +
                '</span>' +
                '<span class="k t t-if-dv">' +
                '<i class="fa fa-toggle-on font-ic" aria-hidden="true"></i>' + (user.active === true ? 'Hoạt động':'Khóa') + '' +
                '</span>' +
                '</div>' +
                '<div class="k f-name">' +
                '<div class="k bd-bnt">' +
                '<a href="/admin/file" target="_blank"><span class="k t bnt-ed-dv">Chi tiết Đảng viên</span></a>' +
                '</div>' +
                '<div class="k bd-bnt">' +
                '<span class="k t bnt-ed-dv">Khóa</span>' +
                '</div>' +
                '<div class="k bd-bnt">' +
                '<span class="k t bnt-ed-dv" data-toggle="modal" onclick="getUserById(bindingUserBuId,' + user.usid + ')" data-target="#modalupdateuser">Cập nhật tài khoản</span>' +
                '</div>' +
                '</div>' +
                '</div>';
            $("#list-item-us").append(view);

            ;
        }
    }
}

//get all chibo
function getAllChiBo(callback) {

    $.ajax({
        type: "get",
        url: linkserver + "adchibo/getAllChiBo",
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
function bindingChiBo(data) {
    if (data.success && data.data.length > 0) {
        $("#sl-chb-addnew option").remove();
        cbid = data.data[0].cbid;
        for (var i in data.data) {
            $("#sl-chb-addnew").append('<option value="' + data.data[i].cbid + '">' + data.data[i].tencb + '</option>');
        }
    }
    else {
        bootbox.alert("Vui lòng thêm ít nhất một Chi bộ trước khi thêm mới Đảng viên");
    }
}
function getOrganization(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "AdOrganization/getAllOrganization",
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
function bindingOrg(data) {
    if (data.success && data.data.length > 0) {
        $("#sl-og-addnew option").remove();
        for (var i in data.data) {
            $("#sl-og-addnew").append('<option value="' + data.data[i].ogid + '">' + data.data[i].nameog + '</option>');
        }
    }
    else {
        bootbox.alert("Vui lòng thêm ít nhất một đơn vị");
    }
}
//get title in Dang
function getTitle(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "AdTitle/getAllTitle",
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
function bindingTitle(data) {
    if (data.success && data.data.length > 0) {
        $("#sl-title-addnew option").remove();
        titleid = data.data[0].titleid;
        for (var i in data.data) {
            var item = data.data[i];
            $("#sl-title-addnew").append('<option value="' + item.titleid + '">' + item.nametitle + '</option>');
        }
    }
    else {
        bootbox.alert("Vui lòng thêm các chức vụ Đảng trước khi thêm Đảng viên!");
    }
}

function showTabInsertUser() {
    getAllChiBo(bindingChiBo);
    //getOrganization(bindingOrg);
    getTitle(bindingTitle);
}

function insertUser() {
    var bol = true;
    var madv = $("#ip-madv-addnew").val();
    var newpass = $("#ip-pass").val();
    var cfpass = $("#ip-cf-pass").val();
    if (!checkData(madv, newpass, cfpass)) {
        return;
    }
    var data = {
        'madv': madv.trim(),
        'cbid': cbid,
        'ngaydenchibo': $("#day-create-cb").val(),
        'roleid': role,
        'titleid': titleid,
        'active': 0,
        'password': cfpass.trim(),
    };
    if (bol) {
        bol = false;
        $.ajax({
            url: linkserver + "aduser/insertUser",
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
                    $('#modalinsertdangvien').modal('toggle');
                    bootbox.alert({
                        message: "Thêm tài khoản thành công!",
                        callback: function () {
                            emptyForm();
                            //getDangBo(bindingDangBo);
                        }
                    })
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
function checkData(madv, newpass, cfpass) {
    if (madv.trim().length < 8) {
        $("#ip-madv-addnew").addClass("err-ip");
        $(".err-validate").show();
        return false;
    }
    else {
        $("#ip-madv-addnew").removeClass("err-ip");
    }
    if (newpass !== cfpass || cfpass.length < 6) {
        $("#ip-pass").addClass("err-ip");
        $("#ip-cf-pass").addClass("err-ip");
        $(".err-validate").show();
        return false;
    }
    else {
        $("#ip-pass").removeClass("err-ip");
        $("#ip-cf-pass").removeClass("err-ip");
    }
    return true;
}
function emptyForm() {
    $("#ip-madv-addnew").val("");
    $("#ip-pass").val("");
    $("#ip-cf-pass").val("");
    // $("#sl-db-att").append('<option value="' + item.dbid + '">' + item.tendb + '</option>');
}

//get detail user by id
function getUserById(callback,id) {
    $.ajax({
        type: "get",
        url: linkserver + "aduser/getDetalUser?id=" + id,
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
function bindingUserBuId(data) {
    if (data.success && data.data) {
        var item = data.data;
    }
}