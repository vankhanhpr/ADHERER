
var formData = new FormData();
function changeView(id,fileid,option) {
    $("#upload-doc").click();
    $("#upload-doc").change(function () {
        readFileUpload(this, id,fileid,option);
    });
}
function readFileUpload(input, id, fileid ,option) {
    if (input.files && input.files[0]) {
        if (formData.get(option) !== null) {
            formData.delete(option);
        }
        formData.append(option, input.files[0]);
        formData.append('formfileid', id);
        formData.append('fileid', fileid);
        var x = input.files[0];
        var reader = new FileReader();
        //reader.onload = function (e) {
        //    $(".name-referral").text(x.name);
        //};
        //reader.readAsDataURL(input.files[0]);
    }
    //$("#upload-referral").val("");
}

function updateFormFile() {
    $.ajax({
        url: linkserver + "formfile/updateFormFile",
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
                message: "Có lỗi xảy ra vui lòng thử lại sau"
            });
        },
        success: function (data) {
            if (data.success) {
                //bootbox.alert({
                //    message: "Cập nhật thông tin thành công!",
                //    callback: function () {
                //        $(".bnt-add-fml").show();
                //        getDangVien(formData.get('usid'), bindingFile);
                //    }
                //});
            }
            else {
                bootbox.alert("Có lỗi xảy ra vui lòng kiểm tra lại thông tin!");
            }
        }
    });
}

function getFormFileByChiBo(id,callback) {
    $.ajax({
        type: "get",
        url: linkserver + "formfile/getFormFileWidthChiBo?id=" + id,
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
function getDay(day) {
    var currentday = new Date();
    if (day > currentday) {
        return 0;
    }
    var year = day.getFullYear - currentday.getFullYear;

}
function bindingFormFile(data) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var item = data.data[i];
            var s = getData(item.ngayvaodangct);
            console.log(s);
            $("#list-user-dubi").append(`<div class=" k border-item">
                                <div class="k img-avt"></div>
                                <div class="k f-name-timeline">
                                    <span class="k t t-if-dv">
                                        <i class="fa fa-id-card-o font-ic" aria-hidden="true"></i>
                                        <span id="">`+item.madv+`</span>
                                    </span>
                                    <span class="k t t-if-dv">
                                        <i class="fa fa-user-circle-o font-ic" aria-hidden="true"></i>
                                        <span id="">`+ item.hotendangdung+`</span>
                                    </span>
                                    <span class="k t t-if-dv">
                                        <i class="fa fa-calendar" aria-hidden="true"></i>
                                        <span id="">`+ formatDate(new Date(item.ngayvaodangct)) +`</span>
                                    </span>
                                </div>
                                <div class="k f-body-user">
                                    <div class="k item-body-user">
                                        <span class="k t text-note-body-user">Tiến trình</span>
                                        <progress class="k t progress-bar" id="file" data-label="`+ s + `tháng/12tháng" max="12" value="` + s+`"> </progress>
                                    </div>
                                </div>
                                <div class="k item-body-user">
                                    <span class="k t text-note-body-user">Thủ tục chuyển thành Đảng viên chính thức</span>

                                    <div id="timeline-wrap">
                                        <div id="timeline"></div>
                                        <div class="marker mfirst timeline-icon one" style= "background-color:`+ (item.formfile.giaychungnhanboiduong ? `#8cfa95` : `#536295`) + `"onclick="changeView(` + item.formfile.formfileid + `,` + item.fileid + `,'giaychungnhanboiduong'` +`)">
                                            `+ (item.formfile.giaychungnhanboiduong ? `<i class="fa fa-check"></i>` :`<i class="fa fa-pencil"></i>`)+`
                                        </div>
                                        <div class="marker m2 timeline-icon two" onclick="changeView(`+ item.formfile.formfileid +`,` + item.fileid +`,giaychungnhanboiduong` +`)">
                                            <i class="fa fa-pencil"></i>
                                        </div>
                                        <div class="marker m3 timeline-icon three" onclick="changeView()">
                                            <i class="fa fa-pencil"></i>
                                        </div>
                                        <div class="marker m4 timeline-icon four" onclick="changeView()">
                                            <i class="fa fa-pencil"></i>
                                        </div>
                                        <div class="marker mlast timeline-icon five" onclick="changeView()">
                                            <i class="fa fa-pencil"></i>
                                        </div>
                                        <input id="upload-doc" class="hidden" style="display:none" type="file" accept="image/*" multiple="">

                                    </div>
                                    <div class="k tab-view-note">
                                        <div class="k timeline-panel tl1">
                                            <p class="t text-timeline">Chứng nhận học lớp bồi dưỡng</p>
                                        </div>
                                        <div class="k timeline-panel tl1">
                                            <p class="t text-timeline">Bản tự kiểm điểm</p>
                                        </div>
                                        <div class="k timeline-panel tl1">
                                            <p class="t text-timeline">Nhận xét của người phân công giúp đỡ</p>
                                        </div>
                                        <div class="k timeline-panel tl1">
                                            <p class="t text-timeline">Nghị quyết chi bộ</p>
                                        </div>
                                        <div class="k timeline-panel tl1">
                                            <p class="t text-timeline">Nghị quyết kết nạp</p>
                                        </div>
                                    </div>

                                </div>
                            </div>`);
        }
    }
}

function getData(day) {
    var x = new Date();
    var y = new Date(day);
    if (x.getFullYear() === y.getFullYear()) {
        return y.getMonth() - x.getMonth();
    }
    else
        if (y.getFullYear() - x.getFullYear() === 1) {
            return y.getMonth() + (12 - x.getMonth());
        }
        else {
            var total = x.getMonth() + y.getMonth();
            for (var i = y.getFullYear() + 1; i < x.getFullYear(); i++) {
                total += 12;
            }
            return total;
        }
}