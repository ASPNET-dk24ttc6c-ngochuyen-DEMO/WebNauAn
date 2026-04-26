using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebDayNauAn
{
    public partial class _Default : System.Web.UI.Page
    {
        // Lấy chuỗi kết nối từ Web.config
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        // 🍽️ Hàm tải toàn bộ danh sách món ăn
        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Recipes ORDER BY Id DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rpRecipes.DataSource = dt;
                rpRecipes.DataBind();
            }
        }

        // 🔍 Hàm xử lý tìm kiếm
        protected void Search_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Sử dụng LIKE và tham số @name để tìm kiếm an toàn
                string sql = "SELECT * FROM Recipes WHERE Name LIKE @name ORDER BY Id DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm dấu % vào hai đầu từ khóa để tìm kiếm gần đúng
                cmd.Parameters.AddWithValue("@name", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Cập nhật lại danh sách hiển thị
                rpRecipes.DataSource = dt;
                rpRecipes.DataBind();

                // Nếu không tìm thấy kết quả nào, có thể thông báo (tùy chọn)
                if (dt.Rows.Count == 0)
                {
                    // Bạn có thể thêm một Label thông báo "Không tìm thấy" nếu muốn
                }
            }
        }

        // 🔄 Hàm reset tìm kiếm (Hiện tất cả)
        protected void Reset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Xóa nội dung trong ô nhập
            LoadData(); // Tải lại toàn bộ dữ liệu
        }
    }
}