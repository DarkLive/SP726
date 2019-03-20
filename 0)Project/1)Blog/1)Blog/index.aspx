<%@ Page Title="Blog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_1_Blog.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
    <script>
        $(document).ready(function () {
            $("nav ul li a[href='index.aspx']").addClass("active disabled");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
    <img src="imgs/banner.jpg" class="img-fluid" style="height: 100%" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Mid" runat="server">
    <!-- MidLeft -->
    <section class="col-lg-2 mb-2 p-2 float-left">
        <asp:Repeater ID="CategoriesList" runat="server">
            <HeaderTemplate>
                <ul class="list-group">
                    <li class="list-group-item list-group-item-dark">Categories</li>
            </HeaderTemplate>
            <ItemTemplate>
                <li class="list-group-item list-group-item-action"><%# Eval("catName") %></li>
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
        <br />
        <asp:Repeater ID="Last5Post" runat="server">
            <HeaderTemplate>
                <ul class="list-group">
                    <li class="list-group-item list-group-item-dark">Last Posts</li>
            </HeaderTemplate>
            <ItemTemplate>
                <li class="list-group-item list-group-item-action"><%# Eval("artTitle") %></li>
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
    </section>
    <!-- MidRight -->
    <asp:Repeater ID="PostRepeater" runat="server">
        <ItemTemplate>
            <section class="col-lg-10 float-left p-2 mb-2 border">
                <section class="card float-left" style="width: 10rem">
                    <asp:Image ID="con_Image" class="card-img-top" runat="server" ImageUrl='<%# Eval("artImage")%>' />
                    <section class="card-body" runat="server">
                        <h5 id="con_Author" class="card-title" runat="server"><%# Eval("artWriter")%></h5>
                        <p id="con_Title" class="card-text" runat="server"><%# Eval("artTitle")%></p>
                        <p id="con_Date" class="card-text" runat="server"><%# Eval("artPublishDate")%></p>
                    </section>
                </section>
                <article class="ml-1 float-left" style="width: calc(98% - 10rem)">
                    <p id="con_Text" runat="server"><%# Eval("artText")%></p>
                </article>
            </section>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
