/// <reference path="jquery-1.12.4.js" />
/// <reference path="jquery-1.12.4.intellisense.js" />

function postwrapper(url, parameter, handler, msg) {
    var divexecuting = $(".executing");
    if (divexecuting.data("flag"))
        return;
    divexecuting.data("flag", "1");
    divexecuting.show();
    toastr.options.positionClass = "toast-middle-center";
    toastr.options.timeOut = 0;
    toastr.options.extendedTimeOut = 0;
    toastr.clear();
    toastr.info(msg || "处理中...");
    $.post(url, parameter, function (rt) {
        divexecuting.data("flag", "");
        divexecuting.hide();
        toastr.clear();
        toastr.options.timeOut = 1000;
        if (rt.Status != 200) {
            toastr.error(rt.Msg);
            return;
        }
        handler(rt);
    });
}