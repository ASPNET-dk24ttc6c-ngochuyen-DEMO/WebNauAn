<%@ Page Title="Đăng nhập" Language="C#" MasterPageFile="~/Gdien.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebDayNauAn.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container" style="margin-top:50px;">
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
            <div class="panel panel-primary">
                <div class="panel-heading">ĐĂNG NHẬP HỆ THỐNG</div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>Tên đăng nhập:</label>
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="admin" />
                    </div>
                    <div class="form-group">
                        <label>Mật khẩu:</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
                    </div>
                    <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="btn btn-primary btn-block" OnClick="btnLogin_Click" />
                    <br />
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>