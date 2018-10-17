function btnIngresar() {
    $.ajax({
        url: "../Login/setToken",
        async: "false",
        type: "post",
        dataType: "text",
        success: function (data) {
            $("#tokenId").val(data);
        }
    });
}