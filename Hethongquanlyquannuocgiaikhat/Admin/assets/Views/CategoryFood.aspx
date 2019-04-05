<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="CategoryFood.aspx.cs" Inherits="Admin_Views_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý danh muc thức ăn
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <asp:Button ID="btnThemChuyenMuc" runat="server" CssClass="btn btn-sm btn-primary" Text="Thêm danh mục" OnClick="btnThemChuyenMuc_Click" />
    <br />
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="false">
        <div class="panel-heading">Thông tin </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">Mã loại thức ăn</label>
                <asp:TextBox runat="server" CssClass="form-control"  Enabled="false" ID="txtMaChuyenMuc" placeholder="Nhập mã loại thức ăn" />
            </div>
            <div class="form-group">
                <label for="">Tên loại thức ăn</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTenChuyenMuc" placeholder="Nhập tên loại thức ăn" />
            </div>            
            <br />
            <asp:Button runat="server" ID="btnSave" CssClass="btn btn-sm btn-primary" Text="Lưu và thêm" OnClick="btnSave_Click" />
            <asp:Button runat="server" ID="btnSaveChanges" CssClass="btn btn-sm btn-success" Text="Lưu và đóng" OnClick="btnSaveChanges_Click" />
            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-sm btn-default" Text="Đóng" OnClick="btnCancel_Click" />
            &nbsp;<asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
    </asp:Panel>

    <br />
    <div class="panel panel-primary">
        <div class="panel-heading">
            Danh sách danh mục thức ăn
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="idCategoryFood" GridLines="None" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="idCategoryFood" HeaderText="Mã chuyên mục" />
                    <asp:BoundField DataField="name" HeaderText="Tên chuyên mục" />
                    <asp:HyperLinkField DataNavigateUrlFields="idCategoryFood" DataNavigateUrlFormatString="?Action=Edit&amp;ID={0}" HeaderText="Sửa" Text="Sửa" />
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDel" Text="Xóa" runat="server"
                                OnClick="btnXoa_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa ?')" CommandName="Delete"
                                CommandArgument='<%# Eval("idCategoryFood") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
