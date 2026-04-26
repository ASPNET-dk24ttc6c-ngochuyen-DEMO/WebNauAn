using System;
using System.Data.SqlClient;
using System.Configuration;

namespace WebDayNauAn
{
    public partial class Login : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Truy vấn kiểm tra tài khoản
                string sql = "SELECT COUNT(*) FROM Users WHERE Username=@user AND Password=@pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // 🔥 SỬA TẠI ĐÂY: Đổi "Username" thành "user" để khớp với MasterPage
                    Session["user"] = txtUsername.Text;

                    // Chuyển hướng về trang chủ
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblMsg.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                }
            }
        }
    }
}