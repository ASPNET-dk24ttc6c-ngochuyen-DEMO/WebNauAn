using System;
using System.Data.SqlClient;
using System.Configuration;

namespace WebDayNauAn
{
    public partial class Detail : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Recipes WHERE Id=@id", conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataReader rd = cmd.ExecuteReader();

                            if (rd.Read())
                            {
                                lblName.Text = rd["Name"].ToString();
                                lblDesc.Text = rd["Description"].ToString();

                                string imgPath = rd["Image"].ToString();
                                if (imgPath.StartsWith("/"))
                                    imgRecipe.Src = "~" + imgPath;
                                else
                                    imgRecipe.Src = "~/images/" + imgPath;

                                // --- 3. XỬ LÝ NỘI DUNG CHI TIẾT ---
                                string rawDetail = rd["RecipeDetail"].ToString();

                                // Xóa các đường kẻ thừa trong database
                                rawDetail = rawDetail.Replace("----------", "");

                                // 🍎 Xử lý NGUYÊN LIỆU
                                rawDetail = rawDetail.Replace("NGUYÊN LIỆU", "<b style='color:#d9534f; font-size:18px;'>🍎 NGUYÊN LIỆU</b><br/>");

                                // 👨‍🍳 Xử lý CÁCH CHẾ BIẾN (Thêm 2 lần xuống dòng để tách đoạn)
                                
                                rawDetail = rawDetail.Replace("Cách chế biến", "<br/><br/><b style='color:#d9534f; font-size:18px;'>👨‍🍳 CÁCH CHẾ BIẾN</b><br/>");

                                // 💡 Xử lý CÁCH CHỌN (Thêm icon bóng đèn và màu xanh lá)
                                rawDetail = rawDetail.Replace("Cách chọn:", "<br/><br/><b style='color:#2e7d32; font-size:18px;'>💡 CÁCH CHỌN</b><br/>");
                                rawDetail = rawDetail.Replace("Cách chọn", "<br/><br/><b style='color:#2e7d32; font-size:18px;'>💡 CÁCH CHỌN</b><br/>");

                                // ✨ THÀNH PHẨM 
                                rawDetail = rawDetail.Replace("THÀNH PHẨM", "<br/><br/><b style='color:#0275d8; font-size:18px;'>✨ THÀNH PHẨM</b><br/>");

                                // Xử lý các dấu gạch đầu dòng liệt kê nguyên liệu
                                rawDetail = rawDetail.Replace("- ", "<br/> • ");

                                // Xử lý làm đậm các số thứ tự bước làm 1. 2. 3.
                                for (int i = 1; i <= 15; i++)
                                {
                                    string step = i + ". ";
                                    rawDetail = rawDetail.Replace(step, "<br/><br/><b>" + step + "</b>");
                                }

                                // Đổi dấu xuống dòng vật lý trong SQL thành thẻ <br/> của HTML
                                rawDetail = rawDetail.Replace("\n", "<br/>");

                                ltrDetail.Text = rawDetail;
                            }
                            else
                            {
                                lblName.Text = "Không tìm thấy món ăn!";
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            Response.Write("Lỗi: " + ex.Message);
                        }
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}