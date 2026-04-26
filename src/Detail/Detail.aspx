<%@ Page Title="Chi tiết món ăn" Language="C#" MasterPageFile="~/Gdien.master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="WebDayNauAn.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container" style="margin-top:30px;">
    <div class="row">
        <div class="col-md-6">
            <img id="imgRecipe" runat="server" class="img-responsive img-thumbnail" style="width:100%;height:350px;object-fit:cover;" />
        </div>
        <div class="col-md-6">
            <h2 style="color:#d9534f;font-weight:bold;">
                <asp:Label ID="lblName" runat="server" />
            </h2>
            <hr />
            <h4>Mô tả:</h4>
            <p><asp:Label ID="lblDesc" runat="server" /></p>
            <h4>Cách làm:</h4>
            <div style="background:#f9f9f9;padding:15px;border-radius:10px;">
                <asp:Literal ID="ltrDetail" runat="server" />
            </div>
            <br />
            <a href="Default.aspx" class="btn btn-primary"> Quay lại trang chủ </a>
        </div>
    </div>
</div>
</asp:Content>