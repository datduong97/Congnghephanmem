<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="QLBan.aspx.cs" Inherits="Admin_Views_QLDatBan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Quản lý bàn
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <asp:Button ID="btnThemChuyenMuc" runat="server" CssClass="btn btn-sm btn-primary" Text="Thêm bàn" OnClick="btnThemChuyenMuc_Click" />
    <br />
    <asp:Panel CssClass="panel panel-primary" ID="pnlThem" runat="server" Visible="false">
        <div class="panel-heading">Thông tin </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="">Mã bàn</label>
                <asp:TextBox runat="server" CssClass="form-control"  Enabled="false" ID="txtMaChuyenMuc" placeholder="Hệ thống tự động sinh mã" />
            </div>
            <div class="form-group">
                <label for="">Tên bàn</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTenChuyenMuc" placeholder="Nhập tên bàn" />
            </div>       
           <div class="form-group">
                <label for="">Trạng thái</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTrangthai" placeholder="Nhập trạng thái" />
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
            Danh sách bàn
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvChuyenMuc" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="idTable" GridLines="None" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="idTable" HeaderText="Mã bàn" />
                    <asp:BoundField DataField="name" HeaderText="Tên bàn" />
                    <asp:BoundField DataField="status" HeaderText="Trạng thái" />
                    <asp:HyperLinkField DataNavigateUrlFields="idTable" DataNavigateUrlFormatString="?Action=Edit&amp;ID={0}" HeaderText="Sửa" Text="Sửa" />
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDel" Text="Xóa" runat="server"
                                OnClick="btnXoa_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa ?')" CommandName="Delete"
                                CommandArgument='<%# Eval("idTable") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
