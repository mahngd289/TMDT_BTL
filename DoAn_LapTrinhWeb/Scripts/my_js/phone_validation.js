$(document).ready(function () {
    // Chỉ cho phép nhập số vào trường điện thoại
    $("#Phone").on("input", function (e) {
        // Loại bỏ tất cả các ký tự không phải số
        var input = $(this).val().replace(/[^0-9]/g, '');
        $(this).val(input);
    });

    // Kiểm tra trước khi submit form
    $("form").submit(function () {
        var phone = $("#Phone").val();
        if (phone && !/^[0-9]+$/.test(phone)) {
            alert("Vui lòng chỉ nhập số vào trường điện thoại");
            return false;
        }
        return true;
    });
});