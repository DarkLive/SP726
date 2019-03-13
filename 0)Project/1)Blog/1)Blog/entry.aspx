<%@ Page Title="Administirator Panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="entry.aspx.cs" Inherits="_1_Blog.entry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
    <script>
        $(document).ready(function () {
            $("nav ul li a[href='entry.aspx']").addClass("active disabled");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
    <img src="imgs/banner.jpg" class="img-fluid" style="height: 100%" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Mid" runat="server">
    <section class="col-lg-1 float-left">&nbsp;</section>
    <section class="col-lg-10 float-left">
        <section class="col-lg-12">
            <asp:DataList ID="EntryList" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover table-striped">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">Author</th>
                                <th scope="col">Date</th>
                                <th scope="col">Title</th>
                                <th scope="col">Text</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%# Eval("artID") %></th>
                        <td><%# Eval("artAuthor") %></td>
                        <td><%# Convert.ToDateTime(Eval("artDate")).ToString("dd-MM-yyyy hh:mm") %></td>
                        <td><%# Eval("artTitle") %></td>
                        <td><%# Eval("artText") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:DataList>
        </section>
        <section>
            <form id="addArticle" runat="server">
                <h5>Add Article</h5>
                Author:<br />
                <asp:TextBox ID="in_author" runat="server"></asp:TextBox><br />
                Title:<br />
                <asp:TextBox ID="in_title" runat="server"></asp:TextBox><br />
                Text:<br />
                <asp:TextBox ID="in_text" TextMode="MultiLine" runat="server"></asp:TextBox><br />
                <asp:Button Text="Add" OnClick="articleadd" runat="server" />
            </form>
        </section>
    </section>
</asp:Content>
