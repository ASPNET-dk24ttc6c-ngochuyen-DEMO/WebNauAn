<%@ Page Title="Trang chủ - Dạy Nấu Ăn" Language="C#" MasterPageFile="~/Gdien.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDayNauAn._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container" style="margin-top:20px;">

    <!-- 🔍 THANH TÌM KIẾM -->
    <div class="row">
        <div class="col-md-6">
            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" 
                placeholder="Nhập tên món ăn cần tìm..." />
        </div>

        <div class="col-md-3">
            <asp:Button ID="btnSearch" Text="Tìm kiếm" runat="server" 
                CssClass="btn btn-primary btn-block" 
                OnClick="Search_Click" />
        </div>

        <div class="col-md-3">
            <asp:Button ID="btnReset" Text="Hiện tất cả" runat="server" 
                CssClass="btn btn-default btn-block" 
                OnClick="Reset_Click" />
        </div>
    </div>

    <br />

    <!-- 🍽 DANH SÁCH MÓN ĂN -->
    <div class="row">

        <asp:Repeater ID="rpRecipes" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="panel panel-default" style="min-height:380px; box-shadow: 0 2px 5px rgba(0,0,0,0.1);">
                        
                        <div class="panel-heading" style="background-color: #f8f8f8;">
                            <strong style="color: #d9534f; font-size: 16px;"><%# Eval("Name") %></strong>
                        </div>

                        <div class="panel-body" style="padding: 0;">
                            <%-- Sửa lỗi đường dẫn ảnh bằng ResolveUrl --%>
                            <img src='<%# ResolveUrl("~" + Eval("Image")) %>' class="img-responsive" 
                                 style="height:200px; width:100%; object-fit:cover;" />
                        </div>

                        <div class="panel-footer" style="background: white; border-top: none;">
                            <p style="height: 40px; overflow: hidden; text-overflow: ellipsis;">
                                <%# Eval("Description") %>
                            </p>
                            <a href='Detail.aspx?id=<%# Eval("Id") %>' 
                               class="btn btn-danger btn-block">Xem chi tiết</a>
                        </div>

                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>

    <%-- Hiển thị thông báo nếu không tìm thấy món nào --%>
    <div class="row">
        <div class="col-md-12 text-center">
            <asp:Literal ID="ltrNoResult" runat="server"></asp:Literal>
        </div>
    </div>

</div>

</asp:Content>