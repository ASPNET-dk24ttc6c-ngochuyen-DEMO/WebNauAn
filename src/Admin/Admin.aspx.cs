using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace WebDayNauAn
{
    public partial class Admin : System.Web.UI.Page
    {
        // Lấy chuỗi kết nối từ Web.config
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. Kiểm tra bảo mật: Nếu chưa đăng nhập thì đẩy về trang Login
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadAllRecipes();
            }
        }

        // 2. Hàm đổ danh sách tất cả món ăn vào bảng
        private void LoadAllRecipes()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Truy vấn lấy toàn bộ món ăn, món mới nhất hiện lên đầu
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Recipes ORDER BY Id DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rpAdminRecipes.DataSource = dt;
                rpAdminRecipes.DataBind();
            }
        }

        // 3. Hàm xử lý XÓA món ăn
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string id = btn.CommandArgument; // Lấy Id món ăn từ nút bấm

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Recipes WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                // Load lại danh sách sau khi xóa thành công
                LoadAllRecipes();

                // Thông báo nhỏ (tùy chọn)
                Response.Write("<script>alert('Đã xóa món ăn thành công!');</script>");
            }
        }
    }
}