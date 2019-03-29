<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="content.aspx.cs" Inherits="_1_Blog.content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Mid" runat="server">
    <section class="col-lg-2 mb-2 p-2 float-left">
        <asp:Repeater ID="CategoriesList" runat="server">
            <HeaderTemplate>
                <ul class="list-group">
                    <li class="list-group-item list-group-item-dark">Categories</li>
            </HeaderTemplate>
            <ItemTemplate>
                <li class="list-group-item list-group-item-action">
                    <a href='content.aspx?art<%# Eval("catID") %>'><%# Eval("catName") %></a></li>
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
                <li class="list-group-item list-group-item-action">
                    <a href='content.aspx?art<%# Eval("artID") %>'><%# Eval("artTitle") %></a></li>
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
    </section>
    <!-- MidRight -->
    <section id="errorcode" class="col-lg-10 float-left alert alert-danger" visible="false" runat="server">404! WRONG PAGE</section>
    <asp:Repeater ID="PostRepeater" Visible="false" runat="server">
        <ItemTemplate>
            <section class="col-lg-10 float-left p-2 mb-2 border">
                <section class="card float-left" style="width: 10rem">
                    <asp:Image ID="con_Image" class="card-img-top" runat="server" ImageUrl='<%# Eval("artImage")%>' />
                    <section class="card-body" runat="server">
                        <h5 id="con_Author" class="card-title" runat="server"><%# Eval("Account.usrFullName")%></h5>
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
    <asp:Repeater ID="CategoryRepeater" runat="server">
        <ItemTemplate>
            <section class="col-lg-10 float-left p-2 mb-2 border">
                <section class="card float-left" style="width: 10rem">
                    <asp:Image ID="con_Image" class="card-img-top" runat="server" ImageUrl='<%# Eval("Article.artImage")%>' />
                    <section class="card-body" runat="server">
                        <h5 id="con_Author" class="card-title" runat="server"><%# Eval("Account.usrFullName")%></h5>
                        <p id="con_Title" class="card-text" runat="server"><%# Eval("Article.artTitle")%></p>
                        <p id="con_Date" class="card-text" runat="server"><%# Eval("Article.artPublishDate")%></p>
                    </section>
                </section>
            </section>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
