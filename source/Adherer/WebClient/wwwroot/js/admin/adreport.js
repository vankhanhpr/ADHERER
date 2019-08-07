
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

drawChart();

function drawChart() {
    Highcharts.chart('container', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Thống kê tình hình Đảng viên năm 2019'
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
        tooltip: {
            pointFormat: 'Số lượng: <b>{point.y:.0f} người</b>'
        },
        series: [{
            name: 'Population',
            data: [
                ['Chính thức', 24],
                ['Dự bị', 20],
                ['Chuyển đến', 14],
                ['Chuyển đi', 13],
                ['Kết nạp', 13],
                ['Từ trần', 12],
                ['Khai trừ', 12],
                ['Xóa tên', 12],
                ['Xin khỏi Đảng', 12],
                ['Tổng số', 40]
            ],
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