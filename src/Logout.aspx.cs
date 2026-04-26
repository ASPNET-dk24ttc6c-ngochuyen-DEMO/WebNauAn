using System;

namespace WebDayNauAn // Đổi lại đúng namespace của project bạn
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Xóa Session
            Session.Remove("user");
            Session.Abandon();

            // Quay về trang chủ
            Response.Redirect("Default.aspx");
        }
    }
}