<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_1_Blog.index1" %>

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
    <section class="col-lg-1 float-left">&nbsp;</section>
    <section class="col-lg-10 float-left">
        Home Page
        <br />
        <br />
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sollicitudin lacus quis nibh commodo, vitae tincidunt est sodales. Nunc commodo in sem vel gravida. Cras euismod sagittis lectus ac aliquet. Quisque maximus laoreet mi. Integer tincidunt sodales massa, ac dignissim justo fermentum nec. Morbi lorem dolor, commodo nec efficitur sit amet, tincidunt sit amet leo. Duis eget luctus magna, eu finibus risus. Curabitur laoreet interdum neque vel vehicula. Suspendisse potenti. Ut leo dolor, malesuada eu lectus at, viverra bibendum sapien.
        Morbi nec vehicula libero. Pellentesque mauris mi, interdum ac velit et, iaculis scelerisque diam. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec vel ante elementum ex rutrum elementum. Aliquam erat volutpat. Suspendisse faucibus odio tellus, vitae eleifend tellus ultrices non. Fusce lacinia posuere sapien lacinia faucibus.
        Proin ullamcorper, elit sit amet tempus iaculis, nisi sem feugiat lorem, eget accumsan turpis erat eu mi. Praesent eleifend augue ante, non pulvinar mi posuere ac. Donec egestas libero a dui scelerisque, sed maximus lorem ullamcorper. Nullam pharetra, enim ac semper mollis, nunc leo tristique est, sit amet feugiat orci augue at ante. Phasellus posuere ipsum justo, non commodo mauris rhoncus non. Nulla venenatis mi vel lectus consequat, sit amet gravida odio iaculis. Nullam posuere purus ac quam finibus, in convallis enim interdum. Maecenas eu urna a massa posuere pellentesque a ut risus. Proin a pellentesque odio. Duis magna quam, fringilla et neque at, mollis congue purus. Duis ornare sapien at nunc ultricies feugiat. Morbi eget nibh in arcu maximus sagittis. Sed dictum sollicitudin efficitur. Nam non maximus lectus. In faucibus sed lectus ut tincidunt. Aenean consectetur, tellus a egestas ornare, lacus quam varius lacus, id blandit libero magna sed risus.
        Nulla facilisi. Suspendisse rhoncus nulla sit amet lorem convallis, eu aliquet libero malesuada. Nullam consectetur fermentum feugiat. Mauris accumsan ligula vitae mauris porta pretium. Maecenas non placerat nibh, finibus sagittis enim. Praesent risus mauris, aliquam vitae tortor in, interdum ullamcorper leo. Duis egestas vehicula massa, in sodales magna tincidunt non. Curabitur a consequat risus, at finibus libero. Praesent malesuada tellus in leo pellentesque vestibulum. Curabitur fringilla velit vitae luctus consectetur. Fusce et velit sit amet nisi dictum convallis a ac nisl. Nunc felis tortor, dapibus eu imperdiet in, placerat nec lectus. Nunc aliquam sit amet dolor a maximus. Nullam id mi vel lacus tristique luctus sit amet quis metus
        Aenean congue nulla molestie semper placerat. Integer ornare tellus vel ex rhoncus, sit amet condimentum quam finibus. Praesent porta, tellus sed laoreet tincidunt, metus magna malesuada urna, ac dapibus ante nibh sit amet ex. Suspendisse potenti. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Vestibulum tincidunt, est in cursus pulvinar, metus dolor finibus mauris, eget commodo velit nulla venenatis orci. Nullam volutpat eros non nisl dapibus, condimentum suscipit erat congue. Nullam sed nunc a est dignissim aliquet. Quisque at tempus nisl.
    </section>
</asp:Content>
