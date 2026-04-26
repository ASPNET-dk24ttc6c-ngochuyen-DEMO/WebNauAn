<%@ Page Title="Quản lý món ăn" Language="C#" MasterPageFile="~/Gdien.master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebDayNauAn.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container" style="margin-top:30px;">
    <div class="row">
        <div class="col-md-9">
            <h2 style="font-weight:bold; color:#d9534f;">Hệ thống quản lý món ăn</h2>
        </div>
        <div class="col-md-3 text-right">
            <%-- Nút thêm mới nên để đồng bộ với trang quản lý chung --%>
            <a href="ManageRecipe.aspx" class="btn btn-success" style="margin-top:20px;">➕ Thêm món mới</a>
        </div>
    </div>
    <hr />
    
    <table class="table table-bordered table-hover" style="background:white;">
        <thead style="background:#f5f5f5;">
            <tr>
                <th>Tên món</th>
                <th width="150">Hình ảnh</th>
                <th width="200">Thao tác</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rpAdminRecipes" runat="server">
                <ItemTemplate>
                    <tr>
                        <td style="vertical-align:middle;"><strong><%# Eval("Name") %></strong></td>
                        <td style="text-align:center;">
                            <%-- Sửa lại cách hiển thị ảnh để không bị lỗi đường dẫn --%>
                            <img src='<%# ResolveUrl("~" + Eval("Image")) %>' 
                                 style="width:100px; height:60px; object-fit:cover; border-radius:5px; border:1px solid #ddd;" />
                        </td>
                        <td style="vertical-align:middle; text-align:center;">
                            <%-- Sửa link sang trang ManageRecipe dùng chung cho cả Thêm/Sửa --%>
                            <a href='ManageRecipe.aspx?id=<%# Eval("Id") %>' class="btn btn-warning btn-sm">
                                <span class="glyphicon glyphicon-edit"></span> Sửa
                            </a>
                            
                            <asp:LinkButton runat="server" ID="btnDelete" 
                                CommandArgument='<%# Eval("Id") %>' 
                                OnClick="btnDelete_Click" 
                                OnClientClick="return confirm('Bạn có chắc chắn muốn xóa món này không?')" 
                                CssClass="btn btn-danger btn-sm">
                                <span class="glyphicon glyphicon-trash"></span> Xóa
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</div>
</asp:Content>