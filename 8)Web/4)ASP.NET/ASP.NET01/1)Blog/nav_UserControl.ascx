﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="nav_UserControl.ascx.cs" Inherits="_1_Blog.nav_UserControl" %>

<% 
   if ( Session["LoggedInAs"] != null ) {
       nav_Acc.Text = "Logout";
       nav_Acc.NavigateUrl = "~/account.aspx?logout";

       var Cord = new _1_Blog.BlogEntities();
       int SesID = Convert.ToInt32(Session["LoggedInAs"].ToString());
       var tempid = Cord.Accounts
          .Where(temp => temp.usrID == SesID)
          .FirstOrDefault();

       if ( tempid.usrRole == 3 && tempid.usrActive == true ) {
           nav_Admin.Visible = true;
       }
   }
   else nav_Acc.Visible = true;
%>

<section class="col-lg-12">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Project</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarToggle" aria-controls="navbarToggle" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <section class="collapse navbar-collapse" id="navbarToggle">
            <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                <li class="nav-item">
                    <asp:HyperLink ID="nav_Home" class="nav-link" NavigateUrl="~/index.aspx" runat="server">Index<span class="sr-only">(current)</span></asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink ID="nav_About" class="nav-link" NavigateUrl="~/about_us.aspx" runat="server">About Us<span class="sr-only">(current)</span></asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink ID="nav_Admin" class="nav-link" Visible="false" NavigateUrl="~/admin.aspx" runat="server">Administirator Panel<span class="sr-only">(current)</span></asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink ID="nav_Acc" class="nav-link" NavigateUrl="~/account.aspx" Visible="true" runat="server">Login/Register<span class="sr-only">(current)</span></asp:HyperLink>
                </li>
            </ul>
            <form class="form-inline my-2 my-lg-0">
                <input class="form-control mr-sm-2" type="search" placeholder="Search" />
                <button class="btn btn-outline-light my-2 my-sm-0" type="submit">Search</button>
            </form>
        </section>
    </nav>
</section>
