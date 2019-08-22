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
                '<span class=" k t detail-row ">' + item.moneys+' đ'+
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
            "moneys": money.trim(),
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