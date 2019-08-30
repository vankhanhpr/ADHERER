var token = getTokenByLocal().token;
getFinanceByStatus(0, bindingFinance);
getFinanceByStatus(1, bindingFinance);
function getFinanceByStatus(status,callback) {
    $.ajax({
        type: "get",
        url: linkserver + "adfinance/getFinanceByStatus?status=" + status,
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
            callback(data, status);
        }
    });
}
function bindingFinance(data, status) {
    if (data.success && data.data) {
        for (var i in data.data) {
            var item = data.data[i];
            var obj = 'tab-in';
            if (status == 0) {//tieen vao
                obj = 'tab-in';
            }
            else {
                obj = 'tab-out';
            }
            var j = parseInt(i) + 1;
            $("#" + obj).append(' <div class="k title-item-row">'+
                '<span class= " k t detail-row" >'+j+'</span >' +
                '<span class=" k t detail-row ">'+item.name+'</span>' +
                '<span class=" k t detail-row ">' + formatNumber(item.moneys)+' đ'+
                '<i class="fa fa-trash-o" aria-hidden="true"onclick="deleteFinance(' + item.financeid +')"></i>' +
                        '</span>' +
                '</div >');
        }
    }
}

function validateFinance() {
    var name = $("#ip-name-finance").val();
    var money = $("#money").val();
    var checkinsert = true;
    if (checkStr(name.trim())) {
        removeClass('ip-name-finance');
    }
    else {
        addClass('ip-name-finance');
        checkinsert = false;
    }
    if (checkStr(money.trim())) {
        removeClass('money');
    }
    else {
        addClass('money');
        checkinsert = false;
    }
    if (checkinsert) {
        $("#err-insert-finance").hide();
        var data = {
            "name": name.trim(),
            "moneys": covertToString(money.trim()),
            "status": parseInt($("#sl-type-finance").children("option:selected").val())
        };
        insertFinance(data);
    }
    else {
        $("#err-insert-finance").show();
        return;
    }
}
function insertFinance(data) {
    $.ajax({
        url: linkserver + "adFinance/insertFinance",
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(data),
        headers: { 'authorization': `Bearer ${token}` },
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
                $('#modalinsertfinance').modal('toggle');
                bootbox.alert({
                    message: "Thêm mới thông tin thành công!",
                    callback: function () {
                        $(".title-item-row").remove();
                        getFinanceByStatus(0, bindingFinance);
                        getFinanceByStatus(1, bindingFinance);
                    }
                });
            }
            else {
                bootbox.alert("Có lỗi xảy ra vui lòng kiểm tra lại thông tin!");
            }
        }
    });
}
function deleteFinance(id) {
    bootbox.confirm({
        message: "Bạn có muốn xóa trường này không?",
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
                    url: linkserver + "adfinance/deleteFinance?id=" + id,
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
                        bootbox.alert("Xóa thông tin thành công");
                        $(".title-item-row").remove();
                        $("#ip-name-finance").val('');
                        $("#money").val('');
                        getFinanceByStatus(0, bindingFinance);
                        getFinanceByStatus(1, bindingFinance);
                    }
                });
            }
        }
    });
   
}
//validate
function addClass(obj) {
    $('#' + obj).addClass('err-ip');
}
function removeClass(obj) {
    $('#' + obj).removeClass('err-ip');
}
function checkStr(str) {
    var st = str.trim();
    if (st.length < 1) {
        return false;
    }
    return true;
}

$(document).ready(function () {
    //called when key is pressed in textbox
    $("#money").keypress(function (e) {
        //if the letter is not digit then display error and don't type anything
        if (e.which !== 8 && e.which !== 0 && (e.which < 48 || e.which > 57)) {
            return false;
        }
    });
});

drawChart();
function drawChart() {
    Highcharts.chart('container', {

        chart: {
            scrollablePlotArea: {
                minWidth: 700
            }
        },

        data: {
            csvURL: 'https://cdn.jsdelivr.net/gh/highcharts/highcharts@v7.0.0/samples/data/analytics.csv',
            beforeParse: function (csv) {
                return csv.replace(/\n\n/g, '\n');
            }
        },

        title: {
            text: 'Thống kê chi tiêu của Chi bộ trong năm 2019'
        },

        subtitle: {
            text: 'Nguồn : Phòng kế toán TT CNTT'
        },

        xAxis: {
            tickInterval: 7 * 24 * 3600 * 1000, // one week
            tickWidth: 0,
            gridLineWidth: 1,
            labels: {
                align: 'left',
                x: 3,
                y: -3
            }
        },

        yAxis: [{ // left y axis
            title: {
                text: null
            },
            labels: {
                align: 'left',
                x: 3,
                y: 16,
                format: '{value:.,0f}'
            },
            showFirstLabel: false
        }, { // right y axis
            linkedTo: 0,
            gridLineWidth: 0,
            opposite: true,
            title: {
                text: null
            },
            labels: {
                align: 'right',
                x: -3,
                y: 16,
                format: '{value:.,0f}'
            },
            showFirstLabel: false
        }],

        legend: {
            align: 'left',
            verticalAlign: 'top',
            borderWidth: 0
        },

        tooltip: {
            shared: true,
            crosshairs: true
        },

        plotOptions: {
            series: {
                cursor: 'pointer',
                point: {
                    events: {
                        click: function (e) {
                            hs.htmlExpand(null, {
                                pageOrigin: {
                                    x: e.pageX || e.clientX,
                                    y: e.pageY || e.clientY
                                },
                                headingText: this.series.name,
                                maincontentText: Highcharts.dateFormat('%A, %b %e, %Y', this.x) + ':<br/> ' +
                                    this.y + ' sessions',
                                width: 200
                            });
                        }
                    }
                },
                marker: {
                    lineWidth: 1
                }
            }
        },

        series: [{
            name: 'All sessions',
            lineWidth: 4,
            marker: {
                radius: 4
            }
        }, {
            name: 'New users'
        }]
    });
}