<%@ Page Title="Administirator Panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="_1_Blog.admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="src" runat="server">
    <script>
        $(document).ready(function () {
            $("nav ul li a[href='admin.aspx']").addClass("active disabled");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Mid" runat="server">
    <form runat="server">
        <section class="col-lg-12">
            <asp:DataList ID="ArticleList" CssClass="w-100" OnDeleteCommand="ArticleList_DeleteCommand" OnEditCommand="ArticleList_EditCommand" OnCancelCommand="ArticleList_CancelCommand" OnUpdateCommand="ArticleList_UpdateCommand" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">Title</th>
                                <th scope="col">Context</th>
                                <th scope="col">Publish Time</th>
                                <th scope="col">Update Time</th>
                                <th scope="col">Image</th>
                                <th scope="col">Writer</th>
                                <th scope="col">Active</th>
                                <th scope="col">Categories</th>
                                <th scope="col"></th>
                                <th scope="col"></th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <%# Eval("artID") %></th>
                    <td><%# Eval("artTitle") %></td>
                    <td><%# Eval("artText") %></td>
                    <td><%# Convert.ToDateTime(Eval("artPublishDate")).ToString("dd-MM-yyyy hh:mm") %></td>
                    <td><%# Convert.ToDateTime(Eval("artUpdateDate")).ToString("dd-MM-yyyy hh:mm") %></td>
                    <td>
                        <img src="<%# Eval("artImage") %>" class="img-fluid" /></td>
                    <td><%# Eval("Account.usrFullName") %></td>
                    <td><%# Eval("artActive") %></td>
                    <th>
                        <asp:LinkButton ID="btn_Edit" CommandName="Edit" CommandArgument='<%# Eval("artID") %>' runat="server">Edit</asp:LinkButton></th>
                    <th>
                        <asp:LinkButton ID="bnt_Delete" CommandName="Delete" CommandArgument='<%# Eval("artID") %>' runat="server">Delete</asp:LinkButton></th>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox Text='<%# Eval("artID") %>' CssClass="form-control" ReadOnly="true" runat="server" /></td>
                    <td>
                        <asp:TextBox ID="in_Up_Title" Text='<%# Eval("artTitle") %>' CssClass="form-control" runat="server" /></td>
                    <td>
                        <asp:TextBox ID="in_Up_Text" TextMode="MultiLine" Text='<%# Eval("artText") %>' CssClass="form-control" runat="server" /></td>
                    <td>
                        <asp:TextBox ID="in_Up_UpdateDate" TextMode="DateTime" ReadOnly="true" CssClass="form-control" Text='<%# Convert.ToDateTime(Eval("artPublishDate")).ToString("dd-MM-yyyy hh:mm") %>' runat="server" /></td>
                    <td>
                        <asp:TextBox ReadOnly="true" Text="Now" CssClass="form-control" runat="server" /></td>
                    <td>
                        <asp:TextBox ReadOnly="true" Text='<%# Eval("artImage") %>' CssClass="form-control" runat="server" /></td>
                    <td>
                        <asp:TextBox OnLoad="writerload" ReadOnly="true" Text="X" CssClass="form-control" runat="server" /></td>
                    <td>
                        <asp:CheckBox ID="in_Up_Active" Checked='<%# Eval("artActive") %>' CssClass="form-control" runat="server" /></td>
                    <td>
                        <asp:CheckBoxList ID="in_Up_Cat"  OnLoad="category_load" runat="server"></asp:CheckBoxList></td>
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
            <h5>Publish Article</h5>
            Author:<br />
            <asp:TextBox ReadOnly="true" CssClass="form-control" OnLoad="getusername" runat="server"></asp:TextBox><br />
            Title:<br />
            <asp:TextBox ID="in_add_title" CssClass="form-control" runat="server"></asp:TextBox><br />
            Text:<br />
            <asp:TextBox ID="in_add_text" Rows="10" Columns="5" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox><br />
            Categories:<br />
            <asp:CheckBoxList ID="in_add_catcheck" OnLoad="category_load" CssClass="form-check-inline" runat="server"></asp:CheckBoxList><br />
            Image:<br />
            <asp:FileUpload ID="in_add_articlepic" CssClass="form-control" runat="server" /><br />
            <asp:Button Text="Publish" CssClass="form-control" OnClick="publishArticle" runat="server" />
        </section>
        <section class="col-lg-2 float-left">
            <h5>Add Category</h5>
            Category Name:<br />
            <asp:TextBox ID="in_add_catname" CssClass="form-control" runat="server"></asp:TextBox><br />
            <asp:Button Text="Add" CssClass="form-control" OnClick="addCategory" runat="server" />
        </section>
    </form>
</asp:Content>
