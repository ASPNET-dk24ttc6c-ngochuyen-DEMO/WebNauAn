using System;
using System.Data; // Phải có thư viện này để dùng DataTable
using System.Data.SqlClient;
using System.Configuration;

namespace WebDayNauAn
{
    public partial class Category : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string catId = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(catId))
                {
                    LoadData(catId);
                }
            }
        }

        private void LoadData(string catId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Recipes WHERE CategoryId = @catId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@catId", catId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                // --- ĐÂY LÀ DÒNG BẠN ĐANG THIẾU ---
                DataTable dt = new DataTable();

                da.Fill(dt);

                // Gán dữ liệu vào Repeater
                rpRecipes.DataSource = dt;
                rpRecipes.DataBind();

                // Hiển thị tiêu đề trang tùy vào dữ liệu
                if (dt.Rows.Count > 0)
                    titleCategory.InnerText = "Danh sách món ăn";
                else
                    titleCategory.InnerText = "Hiện chưa có món nào trong mục này.";
            }
        }
    }
}