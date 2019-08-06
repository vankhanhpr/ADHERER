﻿var token = getTokenByLocal().token;
showLoading();
getDashBoard();
function getDashBoard() {
    $.ajax({
        type: "get",
        url: linkserver + "dashboard/getDashBoard",
        data: null,
        headers: { 'authorization': `Bearer ${token}` },
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            if (data.success && data.data) {
                var item = data.data;
                $("#totaldangbo").text(item.dangbo);
                $("#totalchibo").text(item.chibo);
                $("#totaldangvien").text(item.dangvien);
                $("#totalorg").text(item.donvi);
                $("#totalform").text(item.bieumau);
                $("#daydangbo").text(formatDate(new Date(item.daydangbo)));
                $("#daychibo").text(formatDate(new Date(item.daychibo)));
                $("#daydangvien").text(formatDate(new Date(item.daydangvien)));
                $("#dayorg").text(formatDate(new Date(item.daydonvi)));
                $("#dayform").text(formatDate(new Date(item.dayform)));
            }
        }
    });
}
groupByDangVien(2019, bindingGroupByDangVien);

function groupByDangVien(year,callback) {
    $.ajax({
        type: "get",
        url: linkserver + "dashboard/countByMount?year=" + year,
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
            console.log(err);
            destroyLoading();
        },
        success: function (data) {
            callback(data, year);
        }
    });
}
function bindingGroupByDangVien(data, year) {
    if (data.success && data.data) {
        var arr = [];
        for (var i = 0; i < 12; i++) {
            var j = parseInt(i) + 1;
            var value = 0;
            for (var k in data.data) {
                if (data.data[k].time.month === j) {
                    value = data.data[k].total;
                    break;
                }
            }
            arr.push(value);
        }
        drawChart(arr,year);
    }
    destroyLoading();
}

function drawChart(arr,year) {
    //var arr = [7.0, 6.9, 9.5, 14.5, 18.4, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6];
    Highcharts.chart('container', {
        chart: {
            type: 'line'
        },
        title: {
            text: ''
        },
        subtitle: {
            text: 'Năm ' + year
        },
        xAxis: {
            categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
        },
        yAxis: {
            title: {
                text: 'Số lượng (người)'
            }
        },
        plotOptions: {
            line: {
                dataLabels: {
                    enabled: true
                },
                enableMouseTracking: false
            }
        },
        series: [{
            name: 'Số lượng Đảng viên',
            data: arr
        }
        ]
    });
}