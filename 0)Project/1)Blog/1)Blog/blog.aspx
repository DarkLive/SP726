<%@ Page Title="Blog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="_1_Blog.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
    <script>
        $(document).ready(function () {
            $("nav ul li a[href='blog.aspx']").addClass("active disabled");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
    <img src="imgs/banner.jpg" class="img-fluid" style="height: 100%" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Mid" runat="server">
    <!-- MidLeft -->
    <section class="col-lg-2 mb-2 p-2 float-left">
        <ul class="list-group">
            <li class="list-group-item list-group-item-dark">Categories</li>
            <li class="list-group-item list-group-item-action">Software</li>
            <li class="list-group-item list-group-item-action">Robotics</li>
            <li class="list-group-item list-group-item-action">Project Management</li>
        </ul>
        <br />
        <ul class="list-group">
            <li class="list-group-item list-group-item-dark">Last Entries</li>
            <li class="list-group-item list-group-item-action">Last Entry 1</li>
            <li class="list-group-item list-group-item-action">Last Entry 2</li>
            <li class="list-group-item list-group-item-action">Last Entry 3</li>
            <li class="list-group-item list-group-item-action">Last Entry 4</li>
        </ul>
    </section>
    <!-- MidRight -->
    <section class="col-lg-10 float-left p-2 border">
        <section class="card float-left" style="width: 10rem">
            <img src="imgs/card1.jpg" class="card-img-top" />
            <section class="card-body">
                <h5 class="card-title">Title</h5>
                <p class="card-text">Writer</p>
                <p class="card-text">Date</p>
            </section>
        </section>
        <article class="ml-1 float-left" style="width: calc(98% - 10rem)">
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam faucibus justo vitae nisi elementum, quis blandit magna consequat. Sed est massa, vehicula sed urna id, malesuada consequat arcu.</p>
        </article>
    </section>
</asp:Content>
