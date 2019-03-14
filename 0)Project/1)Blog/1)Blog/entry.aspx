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
        <form runat="server">
            <section class="col-lg-12">
                <asp:DataList ID="EntryList" runat="server" OnDeleteCommand="EntryList_DeleteCommand" OnEditCommand="EntryList_EditCommand" OnCancelCommand="EntryList_CancelCommand" OnUpdateCommand="EntryList_UpdateCommand">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Author</th>
                                    <th scope="col">Date</th>
                                    <th scope="col">Title</th>
                                    <th scope="col">Text</th>
                                    <th scope="col"> </th>
                                    <th scope="col"> </th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%# Eval("artID") %></td>
                        <td><%# Eval("artAuthor") %></td>
                        <td><%# Convert.ToDateTime(Eval("artDate")).ToString("dd-MM-yyyy hh:mm") %></td>
                        <td><%# Eval("artTitle") %></td>
                        <td><%# Eval("artText") %></td>
                        <th><asp:LinkButton ID="btn_Edit" CommandName="Edit" CommandArgument='<%# Eval("artID") %>' runat="server">Edit</asp:LinkButton></th>
                        <th><asp:LinkButton ID="bnt_Delete" CommandName="Delete" CommandArgument='<%# Eval("artID") %>' runat="server">Delete</asp:LinkButton></th>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="form-control" ReadOnly="true" Text='<%# Eval("artID") %>' runat="server"></asp:TextBox>
                        <td><asp:TextBox ID="in_Up_Author" CssClass="form-control" Text='<%# Eval("artAuthor") %>' runat="server"></asp:TextBox></td>
                        <td><asp:TextBox CssClass="form-control" ReadOnly="true" Text="Now" runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="in_Up_Title" CssClass="form-control" Text='<%# Eval("artTitle") %>' runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="in_Up_Text" CssClass="form-control" Text='<%# Eval("artText") %>' runat="server"></asp:TextBox></td>
                        <th><asp:LinkButton ID="btn_Update" CssClass="form-control" CommandName="Update" CommandArgument='<%# Eval("artID") %>' runat="server">Update</asp:LinkButton></th>
                        <th><asp:LinkButton ID="btn_Cancel" CssClass="form-control" CommandName="Cancel" runat="server">Cancel</asp:LinkButton></th>
                    </EditItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    </table>
                    </FooterTemplate>
                </asp:DataList>
            </section>
            <section>
                <h5>Add Article</h5>
                Author:<br />
                <asp:TextBox ID="in_author" runat="server"></asp:TextBox><br />
                Title:<br />
                <asp:TextBox ID="in_title" runat="server"></asp:TextBox><br />
                Text:<br />
                <asp:TextBox ID="in_text" TextMode="MultiLine" runat="server"></asp:TextBox><br />
                <asp:Button Text="Add" OnClick="articleadd" runat="server" />
            </section>
        </form>
    </section>
</asp:Content>
