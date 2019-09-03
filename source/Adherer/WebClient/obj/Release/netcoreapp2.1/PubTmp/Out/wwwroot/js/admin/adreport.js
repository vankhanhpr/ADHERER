var token = getTokenByLocal().token;
//datetime picker
$(document).ready(function () {
    $('#datepicker-startday ,#datepicker-endday').datetimepicker({
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
        viewMode: 'months',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});
getDangBo();
function getChiBoById(id) {
    $.ajax({
        type: "get",
        url: linkserver + "adchibo/getChiBoByDb?id=" + id,
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
            if (data.success && data.data) {
                $("#select-chibo option").remove();
                for (var i in data.data) {
                    var cb = data.data[i];
                    $("#select-chibo").append('<option value=' + cb.cbid + '>' + cb.tencb + '</option>');
                }
                if (data.data.length > 0) {
                    getRevanue(data.data[0].cbid, bindingRevanue);
                    getUser(data.data[0].cbid, bindingUserByChiBo);
                }

            }
        }
    });
}
function filterUser() {
    var chibo = parseInt($("#select-chibo").children("option:selected").val());
    getUser(chibo, bindingUserByChiBo);
}
$('#select-chibo').on('change', function () {
    getRevanue(parseInt(this.value), bindingRevanue);
    getUser(parseInt(this.value), bindingUserByChiBo);
});
$('#select-dangbo').on('change', function () {
    getChiBoById(parseInt(this.value));
    $(".form-item-user").remove();
});

function getRevanue(id, callback) {
    $.ajax({
        type: "get",
        url: linkserver + "dashboard/getRevanue?id=" + id,
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
function bindingRevanue(data) {
    if (data.success && data.data) {
        var revanue = data.data;
        var arr =
            [
                ['Chính thức', revanue.chinhthuc],
                ['Dự bị', revanue.dubi],
                ['Chuyển đến', revanue.ketnap],
                ['Chuyển đi', revanue.chuyendi],
                ['Kết nạp', revanue.chuyenden],
                ['Từ trần', revanue.tutran],
                ['Khai trừ', revanue.khaitru],
                ['Xóa tên', revanue.xoaten],
                ['Xin khỏi Đảng', revanue.rakhoidang],
                ['Đi nước ngoài', revanue.dinuocngoai],
                ['Tổng số', revanue.all]
            ];
        drawChart(arr, data.data.namechibo);
    }
}
function drawChart(arr,namechibo) {
    Highcharts.chart('container', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Thống kê tình hình Đảng viên Chi bộ ' + namechibo+' năm ' + new Date().getFullYear().toString()
        },
        subtitle: {
            text: 'Nguồn: TT CNTT'
        },
        xAxis: {
            type: 'category',
            labels: {
                rotation: -45,
                style: {
                    fontSize: '13px',
                    fontFamily: 'Verdana, sans-serif'
                }
            }
        },
        yAxis: {
            min: 0,
            title: {
                text: 'Số lượng Đảng viên (người)'
            }
        },
        legend: {
            enabled: false
        },
        credits: {
            enabled: false
        },
        tooltip: {
            pointFormat: 'Số lượng: <b>{point.y:.0f} người</b>'
        },
        series: [{
            name: 'Population',
            data: arr,
            dataLabels: {
                enabled: true,
                rotation: -90,
                color: '#FFFFFF',
                align: 'right',
                format: '{point.y:.0f}', // one decimal
                y: 10, // 10 pixels down from the top
                style: {
                    fontSize: '13px',
                    fontFamily: 'Verdana, sans-serif'
                }
            }
        }]
    });
}
function getUser(id, callback) {
    var fromday = $("#fromday").val();
    var endday = $("#endday").val();
    $.ajax({
        type: "get",
        url: linkserver + "aduser/getUserByChiBo?id=" + id + '&fromday=' + fromday + '&endday=' + endday,
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
function bindingUserByChiBo(data) {
    if (data.success && data.data) {
        $(".form-item-user").remove();
        for (var i in data.data) {
            var item = data.data[i];
            $("#form-show-info-user").append('<div class="k form-item-user">' +
                '<div class= "k t left-text" >' + item.madv + '</div >' +
                '<div class="k t left-text">' + (item.roleid === 2 ? 'Admin' : 'Đảng viên') + '</div>' +
                '<div class="k t left-text">' + (item.active ? 'Hoạt động' : 'Không hoạt động') + '</div>' +
                '<div class="k t left-text">' + formatDate(new Date(item.ngaydenchibo)) + '</div>' +
                '<div class="k t left-text">' + (item.lydoden === 0 ? 'Kết nạp' : 'Chuyển đến') + '</div>' +
                '</div>');
        }
    }
}

function getDangBo() {
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
            if (data.data.length > 0 && data.success) {
                for (var i in data.data) {
                    var item = data.data[i].db;
                    $("#select-dangbo").append(' <option value=' + item.dbid + '>' + item.tendb + '</option>');
                }
                getChiBoById(data.data[0].db.dbid);
            }
        }
    });
}