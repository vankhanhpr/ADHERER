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
            getUserByChiBo(bindingUser, parseInt(data.data[0].cbid));
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
        $("#sl-title option").remove();
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




//chuyển sinh hoạt đến
// brower picture
var formData = new FormData();
function getImage() {
    $("#upload-referral").click();
    $("#upload-referral").change(function () {
        readImageUpload(this);
    });
}
//add picture to view
function readImageUpload(input) {
    if (input.files && input.files[0]) {
        if (formData.get("giaygioithieu") != null) {
            formData.delete("giaygioithieu");
        }
        formData.append("giaygioithieu", input.files[0]);
        var x = input.files[0];
        var reader = new FileReader();
        reader.onload = function (e) {
            $(".name-referral").text(x.name);
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#upload-referral").val("");
}

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
    formData.append('madv', madv.trim());
    formData.append('cbid', parseInt($("#sl-chibo").children("option:selected").val()));
    formData.append('ngaydenchibo', daytogo);
    formData.append('roleid', 1);
    formData.append('titleid', title);
    formData.append('active', 0);
    formData.append('password', pass.trim());
    formData.append('lydoden', 1);
    formData.append('noisinhhoatcu', oldadress.trim());
    insertUser(formData);
}
var bol = true;
function insertUser(data) {
    if (bol) {
        bol = false;
        $.ajax({
            url: linkserver + "aduser/moveUser",
            type: 'POST',
            dataType: 'json',
            async: false,
            data: data,
            headers: { 'authorization': `Bearer ${token}` },
            processData: false,
            contentType: false,
            cache: false,
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
                        message: "Chuyển Đảng viên đến Chi bộ thành công!",
                        callback: function () {
                            emptyForm();
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

//chuyen di
function getFileMove() {
    $("#upload-file-move").click();
    $("#upload-file-move").change(function () {
        readFileMove(this);
    });
}
function readFileMove(input) {
    if (input.files && input.files[0]) {
        //if (formData.get("giaygioithieu") != null) {
        //    formData.delete("giaygioithieu");
        //}
        //formData.append("giaygioithieu", input.files[0]);
        var x = input.files[0];
        var reader = new FileReader();
        reader.onload = function (e) {
            $(".name-file-move").text(x.name);
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#upload-file-move").val("");
}
function getFileReview() {
    $("#upload-file-review").click();
    $("#upload-file-review").change(function () {
        readFileReview(this);
    });
}
function readFileReview(input) {
    if (input.files && input.files[0]) {
        //if (formData.get("giaygioithieu") != null) {
        //    formData.delete("giaygioithieu");
        //}
        //formData.append("giaygioithieu", input.files[0]);
        var x = input.files[0];
        var reader = new FileReader();
        reader.onload = function (e) {
            $(".file-review").text(x.name);
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#upload-file-review").val("");
}

//var cbid = parseInt($("#sl-chibo").children("option:selected").val());
function getUserByChiBo(callback,id) {
    $.ajax({
        type: "get",
        url: linkserver + "aduser/getUserByChiBoIdForFilter?id="+id,
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

function bindingUser(data) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var item = data.data[i].user;
            $("#select-dangvien").append('<option value="' + item.usid + '">' + item.madv + '</option>');
        }
    }
}