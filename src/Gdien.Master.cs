using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace WebDayNauAn
{
    public partial class Gdien : System.Web.UI.MasterPage
    {
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // LoadMenu chỉ cần chạy lần đầu (IsPostBack = false)
            if (!IsPostBack)
            {
                LoadMenu();
            }

            // LoadUser phải nằm NGOÀI IsPostBack để cập nhật trạng thái 
            // Đăng nhập/Đăng xuất ngay khi trang web tải lại
            LoadUser();
        }

        // 🔥 MENU DANH MỤC
        void LoadMenu()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", conn);
                SqlDataReader rd = cmd.ExecuteReader();

                StringBuilder html = new StringBuilder();

                while (rd.Read())
                {
                    html.Append("<li>");
                    html.Append("<a href='Category.aspx?id=" + rd["Id"] + "'>");
                    html.Append(rd["Name"]);
                    html.Append("</a></li>");
                }

                ltMenu.Text = html.ToString();
            }
        }

        // 🔐 HIỂN THỊ TRẠNG THÁI ĐĂNG NHẬP
        void LoadUser()
        {
            if (Session["user"] != null)
            {
                string username = Session["user"].ToString();
                // Thêm link Admin.aspx vào đây
                ltUser.Text = "<li><a href='Admin.aspx' style='color:yellow;'>⚙ Quản lý món</a></li>" +
                              "<li><a href='#'>Xin chào, " + username + "</a></li>" +
                              "<li><a href='Logout.aspx'>Đăng xuất</a></li>";
            }
            else
            {
                ltUser.Text = "<li><a href='Login.aspx'>Đăng nhập</a></li>";
            }
        }
    }
}