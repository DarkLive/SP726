<%@ Page Title="Index" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_1_Blog.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
    <script>
        $(document).ready(function () {
            $("nav ul li a[href='index.aspx']").addClass("active disabled");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
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

    <section id="carouselX" class="col-lg-10 float-left carousel slide" style="height: 250px" data-ride="carousel">
        <section class="carousel-inner">
            <asp:Repeater ID="sliderRepeaterCurrent" runat="server">
                <ItemTemplate>
                    <section class="carousel-item active overflow-auto col-lg-9">
                        <img class="d-block img-fluid" style="width: 100%; height: 250px" src="<%# Eval("artImage") %>">
                        <section class="carousel-caption border-dark rounded-circle navbar-dark bg-dark d-md-block"><%# Eval("artTitle") %></section>
                    </section>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="sliderRepeater" runat="server">
                <ItemTemplate>
                    <section class="carousel-item">
                        <img class="d-block img-fluid" style="width: 100%; height: 250px" src="<%# Eval("artImage") %>">
                        <section class="carousel-caption border-dark rounded-circle navbar-dark bg-dark d-md-block"><%# Eval("artTitle") %></section>
                    </section>
                </ItemTemplate>
            </asp:Repeater>
        </section>
        <a class="carousel-control-prev" href="#carouselX" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselX" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </section>

</asp:Content>
