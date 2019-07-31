
var formData = new FormData();
getProvinces(bindingProvinces);
//date picker
$(document).ready(function () {
    $('#datepicker-birthday, #datepicker-vaodct,#datepicker-vaoddb,#datepicker-ngayvaodoan').datetimepicker({
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

//show or hide tab family
var bolfml = true;
function changeTabFamily(obj) {
    $(obj).toggleClass("down");
    if (bolfml) {
        $("#tab-family").show(500);
        bolfml = false;
    }
    else {
        $("#tab-family").hide(500);
        bolfml = true;
    }
}
//show or hide tab bonus
var bolbonus = true;
function changeTabBonus(obj) {
    $(obj).toggleClass("down");
    if (bolbonus) {
        $("#tab-bonus").show(500);
        bolbonus = false;
    }
    else {
        $("#tab-bonus").hide(500);
        bolbonus = true;
    }
}
//show or hide tab discipline
var boldiscipline = true;
function changeTabDiscipline(obj) {
    $(obj).toggleClass("down");
    if (boldiscipline) {
        $("#tab-boldiscipline").show(500);
        boldiscipline = false;
    }
    else {
        $("#tab-boldiscipline").hide(500);
        boldiscipline = true;
    }
}
// brower picture
function getImage() {
    $("#multi-file").click();
    $("#multi-file").change(function () {
        readImageUpload(this);
    });
}
//add picture to view
function readImageUpload(input) {
    if (input.files && input.files[0]) {
        if (formData.get("avatar") != null) {
            formData.delete("avatar");
        }
        formData.append("avatar", input.files[0]);
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#img-avt").css("background-image", "url(" + e.target.result + ")");
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file").val("");
}

//get dangvien by id
function getDangVien(id,callback) {
    $.ajax({
        type: "get",
        url: linkserver + "adfile/getFileByUsId?id="+id,
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
function bindingFile(data) {
    if (data.success && data.data) {
        var user = data.data.user;
        var file = data.data.file;
        if (file) {
            $("#madv").val(user.madv);
            $("#namedv").val(file.hotendangdung);
            $("#sl-giotinh option[value='" + (file.gioitinh ? 0 : 1) + "']").prop("selected", true);
            $("#namekhaisinh").val(file.hotenkhaisinh);
            $("#namedangdung").val(file.hotendangdung);
            $("#birthday").val(formatDate(new Date(file.ngaythangnamsinh)));
            $("#sl-nation option[value='" + file.dantoc + "']").prop("selected", true);
            $("#tongiao").val(file.tongiao);
            $("#cmnd").val(file.cmnd);
            $("#noicapcmnd").val(file.noicapcmnd);
            $("#quequan").val(file.quequan);
            $("#hokhauthuongtru").val(file.hokhauthuongtru);
            $("#sl-honnhan option[value='" + (file.honnhan ? 0 : 1) + "']").prop("selected", true);
            $("#suckhoe").val(file.suckhoe);
            $("#nghenghiep").val(file.nghenghiep);
            $("#sl-org option[value='" + file.donvi + "']").prop("selected", true);
            $("#solylich").val(file.solylich);
            $("#sdt").val(file.sdt);
            $("#email").val(file.email);
            $("#ngayvaodangct").val(formatDate(new Date(file.ngayvaodangct)));
            $("#ngayvaodangdb").val(formatDate(new Date(file.ngayvaodangdb)));
            $("#ngayvaodoan").val(formatDate(new Date(file.ngayvaodoan)));
            $("#sl-trinhdovanhoa option[value='" + file.trinhdovanhoa + "']").prop("selected", true);
            $("#chuyenmon").val(file.chuyenmon);
            $("#noicutru").val(file.noicutru);
            //distric/province/ward
            getDistricts(file.matp, bindingDistrict, file.maqh);
            getWard(file.maqh, bindingWard, file.xaid);
            $("#sl-province option[value='" + file.matp + "']").prop("selected", true);
            
        }
        else {
            getDistricts('01', bindingDistrict,'');
            getWard('001', bindingWard,'');
        }
    }
}

//get nations
getNations(bindingNations);
function getNations(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "adnation/getNations",
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
function bindingNations(data) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var nation = data.data[i];
            $("#sl-nation").append('<option value="' + nation.nationid + '">'+nation.name+'</option>');
        }
    }
}

//get organization
getOrganizations(bindingOrganization);
function getOrganizations(callback) {
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
function bindingOrganization(data) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var og = data.data[i];
            $("#sl-org").append('<option value="' + og.ogid + '">' + og.nameog+'</option>');
        }
    }
}

//get province,district,warnd
$('#sl-province').on('change', function () {
    getDistricts(parseInt(this.value), bindingDistrict,'');
});
function getProvinces(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "unit/getProvince",
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
           // bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingProvinces(data) {
    if (data.success && data.data) {
        $("#sl-province option").remove();
        for (var i in data.data) {
            var pr = data.data[i];
            $("#sl-province").append('<option value="' + pr.matp + '">' + pr.name +'</option>');
        }
    }
}

//get district
$('#sl-district').on('change', function () {
    getWard(parseInt(this.value), bindingWard, '');
});
function getDistricts(id,callback,district) {
    $.ajax({
        type: "get",
        url: linkserver + "unit/getDistrictByPrId?id="+id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            // bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data, district);
        }
    });
}
function bindingDistrict(data, district) {
    if (data.success && data.data) {
        $('#sl-district option').remove();
        for (var i in data.data) {
            var dst = data.data[i];
            $('#sl-district').append('<option value="' + dst.maqh + '">' + dst.name +'</option>');
        }
        if (district!='') {
            $("#sl-district option[value='" + district + "']").prop("selected", true);
        }
        else {
            getWard(data.data[0].maqh, bindingWard,'');
        }
    }
}

//get wards
function getWard(id,callback,ward) {
    $.ajax({
        type: "get",
        url: linkserver + "unit/getWardByDsId?id=" + id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            // bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data, ward);
        }
    });
}
function bindingWard(data, ward) {
    if (data.success && data.data) {
        $('#sl-ward option').remove();
        for (var i in data.data) {
            var wa = data.data[i];
            $('#sl-ward').append('<option value="' + wa.xaid + '">' + wa.name + '</option>');
        }
        if (ward!='') {
            $("#sl-ward option[value='" + ward + "']").prop("selected", true);
        }
    }
}

//check values
$("#cmnd,#sdt").keypress(function (e) {
    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
        return false;
    }
});
function validateFile() {
    var namekhaisinh = $("#namekhaisinh").val();
    var namedangdung = $("#namedangdung").val();
    var tongiao = $("#tongiao").val();
    var cmnd = $("#cmnd").val();
    var noicapcmnd = $("#noicapcmnd").val();
    var quequan = $("#quequan").val();
    var hokhauthuongtru = $("#hokhauthuongtru").val();
    var nghenghiep = $("#nghenghiep").val();
    var sdt = $("#sdt").val();
    var email = $("#email").val();
    var chuyenmon = $("#chuyenmon").val();
    var noicutru = $("#noicutru").val();

    if (!checkStr(namekhaisinh)) {
        tonggerClass('namekhaisinh');
    }
    if (!checkStr(tongiao)) {
        tonggerClass('tongiao');
    }
    if (cmnd.length == 9 || cmnd.length == 12) {
        //
    }
    else {
        tonggerClass('cmnd');
        $('.err-validate').show();
    }
    if (!checkStr(noicapcmnd)) {
        tonggerClass('noicapcmnd');
    }
    if (!checkStr(quequan)) {
        tonggerClass('quequan');
    }
    if (!checkStr(hokhauthuongtru)) {
        tonggerClass('hokhauthuongtru');
    }
    if (!checkStr(noicapcmnd)) {
        tonggerClass('noicapcmnd');
    }
    if (!checkStr(namedangdung)) {
        tonggerClass('namedangdung');
    }
    if (!checkStr(nghenghiep)) {
        tonggerClass('nghenghiep');
    }
    if (!checkStr(email)) {
        tonggerClass('email');
    }
    if (!checkStr(chuyenmon)) {
        tonggerClass('chuyenmon');
    }
    if (!checkStr(noicutru)) {
        tonggerClass('noicutru');
    }
    if (!checkStr(sdt) || sdt.length!=9) {
        tonggerClass('sdt');
        $('.err-validate').show();
    }

}
function tonggerClass(obj) {
    $('#' + obj).toggleClass('err-ip');
}
function checkStr(str) {
    var st = str.trim();
    if (st.length > 0) {
        return true;
        $('.err-validate').show();
    }
    return false;
}