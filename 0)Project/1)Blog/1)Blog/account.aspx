<%@ Page Title="Account Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="account.aspx.cs" Inherits="_1_Blog.account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
    <img src="imgs/banner.jpg" class="img-fluid" style="height: 100%" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Mid" runat="server">
    <form runat="server">
        <span id="alertthis" style="visibility:hidden" class="alert alert-danger" runat="server"></span>
        <section class="col-lg-2 float-left">&nbsp;</section>
        <section class="col-lg-4 mr-1 float-left">
            <h5>Login</h5>
            Email: <span class="badge badge-primary">&#42;</span><br />
            <asp:TextBox ID="in_Log_Email" TextMode="Email" MaxLength="225" CssClass="form-control" runat="server"></asp:TextBox><br />
            Password: <span class="badge badge-primary">&#42;</span><br />
            <asp:TextBox ID="in_Log_Password" TextMode="Password" MaxLength="50" CssClass="form-control" runat="server"></asp:TextBox><br /><br />  

            <asp:Button Text="Login" CssClass="form-control" OnClick="login" runat="server" />
        </section>
        <section class="col-lg-4 ml-1 float-left">
            <h5>Register</h5>
            Full Name: <span class="badge badge-primary">&#42;</span><br />
            <asp:TextBox ID="in_Reg_FullName" MaxLength="150" CssClass="form-control" runat="server"></asp:TextBox><br />
            Birthday: <span class="badge badge-primary">&#42;</span><br />
            <asp:TextBox ID="in_Reg_Birthday" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox><br />
            Email Adress: <span class="badge badge-primary">&#42;</span><br />
            <asp:TextBox ID="in_Reg_Email" TextMode="Email" MaxLength="225" CssClass="form-control" runat="server"></asp:TextBox><br />
            Password: <span class="badge badge-primary">&#42;</span><br />
            <asp:TextBox ID="in_Reg_Password" TextMode="Password" MaxLength="50" CssClass="form-control" runat="server"></asp:TextBox><br />
            Avatar: <br />
            <asp:FileUpload ID="in_Reg_Avatar" AllowMultiple="false" CssClass="form-control" runat="server" /><br />

            <asp:Button Text="Register" CssClass="form-control" OnClick="register" runat="server" />
        </section>
        <section class="col-lg-2 float-left">&nbsp;</section>
    </form>
</asp:Content>
