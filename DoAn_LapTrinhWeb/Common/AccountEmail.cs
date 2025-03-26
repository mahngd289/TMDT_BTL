using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_LapTrinhWeb.Common
{
    public class AccountEmail
    {
        //vui lòng không đổi mật khẩu mail, néu mật khảu bị thay đổi vui lòng nhắn tin qua zalo:0948521622
        //để dùng google email gửi email reset cho người khác bạn cần phải vô đây "https://www.google.com/settings/security/lesssecureapps" Cho phép ứng dụng kém an toàn: Bật
        public const string Host = "smtp.gmail.com"; //tên mấy chủ nếu bạn dùng gmail thì đổi  "Host = "smtp.gmail.com"
        //tài khoản email của bạn
        public const string UserEmail = "manhnguyen197155@gmail.com";
        public const string UserEmailSupport = "manhnguyen197155@gmail.com";
        //Mật khẩu Email của bạn
        public const string Password = "ubnb mggq xwln yxks";
        //Tên Email bạn muốn hiển thị khi gửi
        public const string Name = "SuabottotH&H";
        //điền mail của ô vào đi
    }
}