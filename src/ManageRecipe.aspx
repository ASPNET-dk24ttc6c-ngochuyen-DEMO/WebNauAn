<%@ Page Title="" Language="C#" MasterPageFile="~/Gdien.master" AutoEventWireup="true" CodeBehind="ManageRecipe.aspx.cs" Inherits="WebDayNauAn.ManageRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container" style="max-width:700px; margin-top:30px; background:#fff; padding:20px; border-radius:10px; box-shadow: 0px 0px 10px #ccc;">
    <h3 id="lblTitle" runat="server" style="color:#d9534f; font-weight:bold; text-align:center;">THÊM MÓN ĂN MỚI</h3>
    <hr />

    <div class="form-group">
        <label>Tên món ăn:</label>
        <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Nhập tên món..." />
    </div>

    <div class="form-group">
        <label>Hình ảnh:</label>
        <asp:FileUpload ID="fUpload" runat="server" CssClass="form-control" />
        <%-- HiddenField để giữ lại đường dẫn ảnh cũ khi Sửa --%>
        <asp:HiddenField ID="hdImageOld" runat="server" />
    </div>

    <div class="form-group">
        <label>Mô tả ngắn:</label>
        <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="2" />
    </div>

    <div class="form-group">
        <label>Chi tiết cách làm (Sử dụng dấu - để gạch đầu dòng):</label>
        <asp:TextBox ID="txtDetail" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6" />
    </div>

    <div style="text-align:center;">
        <asp:Button ID="btnSave" runat="server" Text="LƯU DỮ LIỆU" CssClass="btn btn-primary btn-lg" OnClick="btnSave_Click" />
        <a href="Admin.aspx" class="btn btn-default btn-lg">Hủy bỏ</a>
    </div>
</div>
</asp:Content>