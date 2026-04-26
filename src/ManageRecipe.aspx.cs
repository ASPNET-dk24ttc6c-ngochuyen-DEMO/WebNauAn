using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace WebDayNauAn
{
    public partial class ManageRecipe : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Bảo mật: Chưa đăng nhập không được vào
            if (Session["user"] == null) Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                // Nếu có ID trên URL => Đang ở chế độ SỬA
                if (Request.QueryString["id"] != null)
                {
                    LoadDataToEdit(Request.QueryString["id"]);
                }
            }
        }

        // Lấy dữ liệu cũ đổ vào Form để sửa
        void LoadDataToEdit(string id)
        {
            lblTitle.InnerText = "CHỈNH SỬA MÓN ĂN";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Recipes WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtName.Text = rd["Name"].ToString();
                    txtDesc.Text = rd["Description"].ToString();
                    txtDetail.Text = rd["RecipeDetail"].ToString();
                    hdImageOld.Value = rd["Image"].ToString(); // Lưu lại đường dẫn ảnh cũ
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string imgPath = hdImageOld.Value; // Mặc định lấy ảnh cũ

            // Nếu người dùng chọn ảnh mới thì Upload
            if (fUpload.HasFile)
            {
                string fileName = Path.GetFileName(fUpload.FileName);
                fUpload.SaveAs(Server.MapPath("~/images/") + fileName);
                imgPath = "/images/" + fileName; // Lưu đường dẫn mới
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "";
                // Nếu không có ID => Thêm mới (INSERT)
                if (Request.QueryString["id"] == null)
                {
                    sql = "INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId) " +
                          "VALUES (@name, @img, @desc, @detail, 1)";
                }
                // Nếu có ID => Cập nhật (UPDATE)
                else
                {
                    sql = "UPDATE Recipes SET Name=@name, Image=@img, Description=@desc, " +
                          "RecipeDetail=@detail WHERE Id=@id";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@img", imgPath);
                cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
                cmd.Parameters.AddWithValue("@detail", txtDetail.Text);
                if (Request.QueryString["id"] != null)
                    cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);

                conn.Open();
                cmd.ExecuteNonQuery();

                // Lưu xong quay về trang quản lý
                Response.Redirect("Admin.aspx");
            }
        }
    }
}