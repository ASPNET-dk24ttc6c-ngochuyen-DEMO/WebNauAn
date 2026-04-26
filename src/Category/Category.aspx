<%@ Page Title="Danh mục món ăn" Language="C#" MasterPageFile="~/Gdien.master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="WebDayNauAn.Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container" style="margin-top:20px;">
    <h2 id="titleCategory" runat="server" style="color:#d9534f;"></h2>
    <hr />
    <div class="row">
        <asp:Repeater ID="rpRecipes" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="panel panel-default" style="min-height:350px;">
                        <div class="panel-heading">
                            <strong><%# Eval("Name") %></strong>
                        </div>
                        <div class="panel-body">
                            <img src='<%# ResolveUrl("~" + Eval("Image")) %>' 
                                 class="img-responsive" 
                                 style="height:180px;width:100%;object-fit:cover;" />
                        </div>
                        <div class="panel-footer">
                            <a href='Detail.aspx?id=<%# Eval("Id") %>' class="btn btn-danger btn-sm">
                                Xem chi tiết
                            </a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
</asp:Content>