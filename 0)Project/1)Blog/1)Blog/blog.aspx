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
            <asp:Image ID="con_Image" class="card-img-top" runat="server" />
            <section class="card-body" runat="server">
                <h5 id="con_Author"  class="card-title" runat="server"></h5>
                <p  id="con_Title" class="card-text" runat="server"></p>
                <p id="con_Date" class="card-text" runat="server"></p>
            </section>
        </section>
        <article class="ml-1 float-left" style="width: calc(98% - 10rem)">
            <p id="con_Text" runat="server"></p>
        </article>
    </section>
</asp:Content>
