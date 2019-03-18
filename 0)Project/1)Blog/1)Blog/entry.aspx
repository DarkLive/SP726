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
                <asp:DataList ID="AuthorList" runat="server" OnCancelCommand="AuthorList_CancelCommand" OnDeleteCommand="AuthorList_DeleteCommand" OnEditCommand="AuthorList_EditCommand" OnUpdateCommand="AuthorList_UpdateCommand">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Author Name</th>
                                    <th scope="col"></th>
                                    <th scope="col"></th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <FooterTemplate>
                        </tbody>
                    </table>
                    </FooterTemplate>
                    <ItemTemplate>
                        <%# Eval("autID") %></td>
                        <td><%# Eval("autName") %></td>
                        <th>
                            <asp:LinkButton ID="btn_Edit" CommandName="Edit" CommandArgument='<%# Eval("autID") %>' runat="server">Edit</asp:LinkButton></th>
                        <th>
                            <asp:LinkButton ID="bnt_Delete" CommandName="Delete" CommandArgument='<%# Eval("autID") %>' runat="server">Delete</asp:LinkButton></th>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="form-control" ReadOnly="true" Text='<%# Eval("autID") %>' runat="server"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="in_Up_AuthorName" CssClass="form-control" Text='<%# Eval("autName") %>' runat="server"></asp:TextBox></td>
                        <th>
                            <asp:LinkButton ID="btn_Update" CssClass="form-control" CommandName="Update" CommandArgument='<%# Eval("autID") %>' runat="server">Update</asp:LinkButton></th>
                        <th>
                            <asp:LinkButton ID="btn_Cancel" CssClass="form-control" CommandName="Cancel" runat="server">Cancel</asp:LinkButton></th>
                    </EditItemTemplate>
                </asp:DataList>
            </section>
            <section class="col-lg-12">
                <asp:DataList ID="ArticleList" runat="server" OnDeleteCommand="EntryList_DeleteCommand" OnEditCommand="EntryList_EditCommand" OnCancelCommand="EntryList_CancelCommand" OnUpdateCommand="EntryList_UpdateCommand">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Author</th>
                                    <th scope="col">Date</th>
                                    <th scope="col">Title</th>
                                    <th scope="col">Text</th>
                                    <th scope="col"></th>
                                    <th scope="col"></th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%# Eval("artID") %></th>
                        <td><%# Eval("autName") %></td>
                        <td><%# Convert.ToDateTime(Eval("artDate")).ToString("dd-MM-yyyy hh:mm") %></td>
                        <td><%# Eval("artTitle") %></td>
                        <td><%# Eval("artText") %></td>
                        <th>
                            <asp:LinkButton ID="btn_Edit" CommandName="Edit" CommandArgument='<%# Eval("artID") %>' runat="server">Edit</asp:LinkButton></th>
                        <th>
                            <asp:LinkButton ID="bnt_Delete" CommandName="Delete" CommandArgument='<%# Eval("artID") %>' runat="server">Delete</asp:LinkButton></th>
                        <th class="invisible"><%# Eval("artAuthor") %></th>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="form-control" ReadOnly="true" Text='<%# Eval("artID") %>' runat="server"></asp:TextBox>
                        <td>
                            <asp:DropDownList ID="in_Up_Author" CssClass="form-control" Style="min-width: 100px" OnLoad="in_Up_Author_Load" runat="server"></asp:DropDownList></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ReadOnly="true" Text="Now" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="in_Up_Title" CssClass="form-control" Text='<%# Eval("artTitle") %>' runat="server"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="in_Up_Text" CssClass="form-control" Text='<%# Eval("artText") %>' runat="server"></asp:TextBox></td>
                        <th>
                            <asp:LinkButton ID="btn_Update" CssClass="form-control" CommandName="Update" CommandArgument='<%# Eval("artID") %>' runat="server">Update</asp:LinkButton></th>
                        <th>
                            <asp:LinkButton ID="btn_Cancel" CssClass="form-control" CommandName="Cancel" runat="server">Cancel</asp:LinkButton></th>
                    </EditItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    </table>
                    </FooterTemplate>
                </asp:DataList>
            </section>
            <section class="col-lg-2 float-left">
                <h5>Add Article</h5>
                Author:<br />
                <asp:DropDownList ID="in_author" CssClass="form-control" runat="server"></asp:DropDownList>
                Title:<br />
                <asp:TextBox ID="in_title" CssClass="form-control"  runat="server"></asp:TextBox><br />
                Text:<br />
                <asp:TextBox ID="in_text" TextMode="MultiLine" CssClass="form-control"  runat="server"></asp:TextBox><br />
                Image:<br />
                <asp:FileUpload ID="in_articlepic" CssClass="form-control" runat="server" />
                <asp:Button Text="Add" OnClick="articleadd" runat="server" />
            </section>
        </form>
    </section>
</asp:Content>
