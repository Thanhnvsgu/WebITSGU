
var thongtinnguoidung = {
    init: function () {
        thongtinnguoidung.RegisterEvents()
    },
    RegisterEvents: function(){
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            // Tra ve tab can chon
            //$("#tabtaikhoan").removeClass('active');
            //$("#tabchucvu").addClass('active');
            //$("#a_taikhoan").attr("aria-expanded", false);
            //$("#a_chucvu").attr("aria-expanded", true);
            //$("#taikhoan1").removeClass('active');
            //$("#taikhoan1").removeClass('in');
            //$("#chucvu1").addClass('active');
            //$("#chucvu1").addClass('in');
            $.ajax({
                url: "/Admin/Thongtinnguoidung/ChangeStatus",
                data: { id: btn.data('tentaikhoan') },
                dataType: "json",
                type:"POST",
                success: function (response) {
                    if (response.status == true) {
                        btn.text("Khóa")
                        btn.css("color", "#ff7676");
                    } else {
                        btn.text("Không khóa")
                        btn.css("color", "#2cabe3");
                    }
                }
            });

        });
        $(".btnsuataikhoan").click(function (e) {
            e.preventDefault();
            var btn = $(this).closest('tr');
            $.ajax({
                url: "/Admin/Thongtinnguoidung/LoadSuataikhoan",
                data: { id: btn.find('.tentaikhoan').text() },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    $(".machucvutaikhoanedit").val(response.Jmachucvu);
                    $(".tentaikhoanedit").val(response.Jtentaikhoan);
                    $(".matkhautaikhoanedit").val(response.Jmatkhau);
                    $(".mailtaikhoanedit").val(response.Jmail);
                    $(".hotenuseredit").val(response.Jhoten);
                    $(".ngaysinhuseredit").val(response.Jngaysinh);
                    $(".sdtuseredit").val(response.Jsdt);
                    $(".quequanuseredit").val(response.Jquequan);
                    
                }
            });


        });
    }
}
thongtinnguoidung.init();