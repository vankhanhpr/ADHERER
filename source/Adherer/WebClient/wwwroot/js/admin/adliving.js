var token = getTokenByLocal().token;
var formData = new FormData();
function getImage() {
    $("#multi-file").click();
    $("#multi-file").change(function () {
        readImageUpload(this);
    });
}
//add picture to view
function readImageUpload(input) {
    if (input.files && input.files[0]) {
        if (formData.get("file") != null) {
            formData.delete("file");
        }
        formData.append("file", input.files[0]);
        var x = input.files[0];
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#name-file").text(x.name);
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file").val("");
}

$(document).ready(function () {
    $('#datepicker-add-new')
        .datetimepicker({
            format: 'DD/MM/YYYY',
            defaultDate: false,
            viewMode: 'months',
            extraFormats: false,
            stepping: 1,
            minDate: false,
            maxDate: false,
            useCurrent: true,
            collapse: true,
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
            toolbarPlacement: 'default',
            showTodayButton: false,
            showClear: false,

            widgetPositioning: {
                horizontal: 'auto',
                vertical: 'auto'
            }
        });
});

function validateAdhererLiving() {
    var title = $("#title").val();
    var time = $("#time-living").val();
    var note = $("#note").val();
    var checkinsert = true;
    if (checkStr(title.trim())) {
        removeClass('title');
    }
    else {
        checkinsert = false;
        addClass('title');
    }
    if (checkStr(note.trim())) {
        removeClass('note');
    }
    else {
        checkinsert = false;
        addClass('note');
    }
    if (checkinsert) {
        $('#err-validate').hide();
        formData.append('title', title.trim());
        formData.append('time', time.trim());
        formData.append('note', note.trim());
        formData.append('dayevent', $("#time-living").val());
        insertAhdererLiving();

    }
    else {
        $('#err-validate').show();
        return;
    }
}
function insertAhdererLiving() {
    $.ajax({
        url: linkserver + "AdhererLiving/insertAdhererLiving",
        type: 'POST',
        dataType: 'json',
        async: false,
        data: formData,
        headers: { 'authorization': `Bearer ${token}` },
        processData: false,
        contentType: false,
        cache: false,
        error: function (err) {
            bootbox.alert({
                message: "Error :" + err.message
            });
        },
        success: function (data) {
            if (data.success) {
                bootbox.alert({
                    message: "Thêm thông tin thành công!",
                    callback: function () {
                        emptyForm();
                        $('#modal-add-living').modal('toggle');
                        getAllLivingAhderer(bindingAdherer);
                    }
                });
            }
            else {
                bootbox.alert("Có lỗi xảy ra vui lòng kiểm tra lại thông tin!");
            }
        }
    });

}

function emptyForm() {
    $("#title").val('');
    $("#time-living").val('');
    $("#note").val('');
    $("#name-file").text('');
}

function addClass(obj) {
    $('#' + obj).addClass('err-ip');
}
function removeClass(obj) {
    $('#' + obj).removeClass('err-ip');
}
function checkStr(str) {
    var st = str.trim();
    if (st.length < 1) {
        //$('.err-validate').show();
        return false;
    }
    return true;
}


getAllLivingAhderer(bindingAdherer);
function getAllLivingAhderer(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "AdhererLiving/getAllAdhererLiving",
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
function bindingAdherer(data) {
    if (data.success && data.data) {
        $(".item-living").remove();
        for (var i in data.data) {
            var item = data.data[i];
            $("#body-item").append('<div class="k item-living">'+
                '<span class= "k t t-living"> ' + item.title + '</span>' +
                '<span class="k t t-time">Thời gian sinh hoạt: ' + formatDate(new Date(item.dayevent)) + '</span>' +
                '<span class="k t note-living">' + item.note+
                '</span>' +
                '<div class="k f-edit-file">' +
                '<a href=' + linkdocument + item.namefiel + '>' +
                '<span class="k t file-close">' + item.namefiel + '</span></a>' +
                '<i class="fa fa-wrench" aria-hidden="true"></i>' +
                '<i class="fa fa-trash-o" aria-hidden="true"onclick="deletelivingAdherer(' + item.livid + ')"></i>' +
                '</div>' +
            '</div >');
        }
    }
}

function deletelivingAdherer(id) {
    bootbox.confirm({
        message: "Bạn có chắc muốn xóa?",
        buttons: {
            confirm: {
                label: 'Yes',
                className: 'btn-success'
            },
            cancel: {
                label: 'No',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    type: "get",
                    url: linkserver + "AdhererLiving/deleteAdhererLiving?id=" + id,
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
                        bootbox.alert({
                            message: "Xóa thông tin thành công!",
                            callback: function () {
                                getAllLivingAhderer(bindingAdherer);
                            }
                        });
                    }
                });
            }
        }
    });  
}