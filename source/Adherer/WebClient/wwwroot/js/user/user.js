//get dangvien by id
//var tokenmodel = strToObj(getTokenByLocal());
disableddatePicker("user-daycmnd");
disableddatePicker("user-ngaythangnamsinh");
disableddatePicker("user-ngayvaodangct");
//disableddatePicker("user-ngayvaodangdb");
disableddatePicker("user-ngayvaodoan");
var token = getTokenByLocal().token;
var id = getTokenByLocal().usid;
if (id != null && typeof id != 'undefined') {
    getInfoUser(id, bindingUserFile);
} else {
    window.location.href = "/login";
}


var parames = [];
parames['idSelectTp'] = "user-matp"; 
getProvinces(parames, bindingProvinces);

var parames1 = [];
parames1['idSelectNation'] = "user-dantoc";
getNations(parames1, bindingNations);

function disableddatePicker(id) {
    //$('#' + id).datePicker('disable');
};

function getInfoUser(id, callback) {
    $.ajax({
        type: "get",
        url: QLDV_LINK_API + "adfile/getFileByUsId?id=" + id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        headers: { 'authorization': `Bearer ${token}` },
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
function bindingUserFile(data) {
    if (data.success && data.data) {
        formData = new FormData();
        var user = data.data.user;
        formData.append("usid", user.usid);
        var file = data.data.file;
        if (data.data.user != null && typeof data.data.user != 'undefined') {
            if (data.data.user.accept != null && typeof data.data.user.accept != 'undefined' && data.data.user.accept == true) {
                $('#btn-edit, #btn-save').show();
            }
        }
        if (file) {
            $("#user-fileid").val(file.fileid);  
            $("#user-usid").val(file.usid); 
            $("#user-madv").val(file.madv);
            $("#user-hotenkhaisinh").val(file.hotenkhaisinh);
            $("#user-hotendangdung").val(file.hotendangdung);
            $("#user-cmnd").val(file.cmnd);
            $("#user-hokhauthuongtru").val(file.hokhauthuongtru);
            $("#user-noicutru").val(file.noicutru);
            $("#user-nghenghiep").val(file.nghenghiep);
            $("#user-chuyenmon").val(file.chuyenmon);
            $("#user-donvi").val(file.donvi);
            $("#user-solylich").val(file.solylich);
            $("#user-email").val(file.email);
            $("#user-sdt").val(file.sdt);
            $("#user-suckhoe").val(file.suckhoe);
            $("#user-quequan").val(file.quequan);
            $("#user-daycmnd").val(convertDay(new Date(file.daycmnd)));
            $("#user-ngaythangnamsinh").val(convertDay(new Date(file.ngaythangnamsinh)));
            $("#user-ngayvaodangct").val(convertDay(new Date(file.ngayvaodangct)));
            $("#user-ngayvaodangdb").val(convertDay(new Date(file.ngayvaodangdb)));
            $("#user-ngayvaodoan").val(convertDay(new Date(file.ngayvaodoan)));
            $("#user-gioitinh option[value='" + (file.gioitinh ? 0 : 1) + "']").prop("selected", true);
            $("#user-honnhan option[value='" + (file.honnhan ? 0 : 1) + "']").prop("selected", true);
            $("#user-noicapcmnd").val(file.noicapcmnd);
            $("#user-tongiao").val(file.tongiao);
            $("#user-trinhdovanhoa").val(file.trinhdovanhoa);
            if (file.avatar) {
                document.getElementById('user-avatar').src = QLDV_PATH_IMAGE + file.avatar;
                //$("#user-avatar").css("background-image", "url(" + QLDV_PATH_IMAGE + file.avatar + ")");
            }
            $("#user-dantoc option[value='" + file.dantoc + "']").prop("selected", true);

            //show data list TP
            //- get list TP from API
            //- append data
            getDistricts("user-maqh", file.matp, bindingDistrict, file.maqh);
            getWard(file.maqh, bindingWard, file.xaid, "user-xaid");
            $("#user-matp option[value='" + file.matp + "']").prop("selected", true);



        }
    };
}

$("#user-matp").on('change', function () {
    getDistricts("user-maqh", this.value, bindingDistrict, '');
});
$("#user-maqh").on('change', function () {
    getWard(this.value, bindingWard, '', "user-xaid");
});

function edit() {
    $(".edit-field").removeAttr("disabled");
}

//UpdateUser

function updateUserInfo(formData) {
    $.ajax({
        url: QLDV_LINK_API + "adFile/updateFile",
        type: 'POST',
        contentType: false,
        processData: false,
        dataType: 'json',
        data: formData,
        headers: { 'authorization': `Bearer ${token}` },
        async: false,
        processData: false,
        statusCode: {
            401: function () {
                alert("erro 401");
            }
        },
        error: function (err) {
            alert(err.message);
        },
        success: function (data) {
            if (data.success == true) {
                window.location.reload();
            }
            else {
                alert(data.message);
            }
        }
    });
}

//update user
//FormData


function processUpdateUser() {
    //check neu con class qldv-error-require thi ko cho luu
    //Neu da remove het roi thi tien hanh lay data va luu len server
    var elemErrors = $(".qldv-error-require");
    if (elemErrors.length > 0) {
        alert("Vui long kiem tra lai du lieu nhap");
    } else {
        var data = $("#user-data").serializeArray();
        var formData = new FormData();
        
        if (data.length > 0) {
            //var dataArr = [];
            for (var i = 0; i < data.length; i++) {
                var key = data[i]['name'];
                var val = data[i]['value'];
            }
                //dataArr[key] = val;
                formData.append(key, val);
            }
            //var dataObj = Object.assign({}, dataArr);
            //$.each(data, function (i, val) {
            //    formData.append(val.name, val.value);
            //});
            updateUserInfo(formData);
        } else {
            alert("data input ko hop le");
        }
        
    }
    
};
