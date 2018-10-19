function btnIngresar() {
    var result = "";
    $.ajax({
        url: "../Login/setToken",
        async: "false",
        type: "post",
        dataType: "text",
        success: function (data) {
            result = data;
            $("#tokenId").val(result);
        }
    });
}

function setFn() {
    var ww = "first round";
    $("#fnA").val(ww);
    $.ajax({
        url: "../Login/setFn",
        async: "false",
        type: "post",
        dataType: "text",
        success: function (data) {
            var x = $("#fn");
            x.val(data);
            ww = "second round";
            $("#fnA").val(ww);
        }
    }).done(function () {
        $("#fnA").val("third round");
    });
}

function setFn2() {
    var data = $("#accessId option:selected").val();
    var x = $("#fn");
    x.val(data);
}

function setKey() {
    var result = "";
    var r = false;
    $.ajax({
        url: "../Login/setToken",
        async: "false",
        type: "post",
        dataType: "text",
        success: function (data) {
            result = data;
            $("#tokenId").val(result);
            r = true;
        }
    }).done(function () {
        alert(r);
        return r;
    });
}