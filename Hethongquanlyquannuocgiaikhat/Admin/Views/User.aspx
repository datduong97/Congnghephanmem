<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Admin_Views_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    Người dùng
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <asp:Button ID="btnThemNguoiDung" runat="server" CssClass="btn btn-sm btn-primary" Text="Thêm người dùng" />
    <br /><br />
    <div class="panel panel-primary">
        <div class="panel-heading">
            Danh sách người dùng
        </div>
        <div class="panel-body">
            <asp:GridView ID="gvNguoiDung" CssClass="table table-responsive table-hover" runat="server" AutoGenerateColumns="False" GridLines="None" DataKeyNames="IDNguoiDung" >
                <Columns>
                    <asp:BoundField DataField="IDNguoiDung" HeaderText="ID" SortExpression="IDNguoiDung" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="TenDangNhap" HeaderText="Tên đăng nhập" SortExpression="TenDangNhap" />
                    <asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" SortExpression="MatKhau" />
                    <asp:BoundField DataField="HoTen" HeaderText="Họ tên" SortExpression="HoTen" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="SoDienThoai" HeaderText="Số điện thoại" SortExpression="SoDienThoai" />
                    <asp:CheckBoxField DataField="QuanTri" HeaderText="Quản trị" SortExpression="QuanTri" />
                    <asp:CheckBoxField DataField="TrangThai" HeaderText="Trạng thái" SortExpression="TrangThai" />
                    <asp:CommandField CancelText="Hủy" DeleteText="Xóa" EditText="Sửa" HeaderText="Tùy chọn" InsertText="Thêm" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Lưu" />
                </Columns>
                
            </asp:GridView>
            <%--<asp:SqlDataSource ID="SqlDataSource" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:NhaHangOnlineConnectionString %>" 
                DeleteCommand="DELETE FROM [tblNguoiDung] WHERE [IDNguoiDung] = @original_IDNguoiDung AND (([TenDangNhap] = @original_TenDangNhap) OR ([TenDangNhap] IS NULL AND @original_TenDangNhap IS NULL)) AND (([MatKhau] = @original_MatKhau) OR ([MatKhau] IS NULL AND @original_MatKhau IS NULL)) AND (([HoTen] = @original_HoTen) OR ([HoTen] IS NULL AND @original_HoTen IS NULL)) AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND (([SoDienThoai] = @original_SoDienThoai) OR ([SoDienThoai] IS NULL AND @original_SoDienThoai IS NULL)) AND (([QuanTri] = @original_QuanTri) OR ([QuanTri] IS NULL AND @original_QuanTri IS NULL)) AND (([TrangThai] = @original_TrangThai) OR ([TrangThai] IS NULL AND @original_TrangThai IS NULL))" 
                InsertCommand="INSERT INTO [tblNguoiDung] ([TenDangNhap], [MatKhau], [HoTen], [Email], [SoDienThoai], [QuanTri], [TrangThai]) VALUES (@TenDangNhap, @MatKhau, @HoTen, @Email, @SoDienThoai, @QuanTri, @TrangThai)" 
                OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tblNguoiDung]" 
                UpdateCommand="UPDATE [tblNguoiDung] SET [TenDangNhap] = @TenDangNhap, [MatKhau] = @MatKhau, [HoTen] = @HoTen, [Email] = @Email, [SoDienThoai] = @SoDienThoai, [QuanTri] = @QuanTri, [TrangThai] = @TrangThai WHERE [IDNguoiDung] = @original_IDNguoiDung AND (([TenDangNhap] = @original_TenDangNhap) OR ([TenDangNhap] IS NULL AND @original_TenDangNhap IS NULL)) AND (([MatKhau] = @original_MatKhau) OR ([MatKhau] IS NULL AND @original_MatKhau IS NULL)) AND (([HoTen] = @original_HoTen) OR ([HoTen] IS NULL AND @original_HoTen IS NULL)) AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND (([SoDienThoai] = @original_SoDienThoai) OR ([SoDienThoai] IS NULL AND @original_SoDienThoai IS NULL)) AND (([QuanTri] = @original_QuanTri) OR ([QuanTri] IS NULL AND @original_QuanTri IS NULL)) AND (([TrangThai] = @original_TrangThai) OR ([TrangThai] IS NULL AND @original_TrangThai IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_IDNguoiDung" Type="Int32" />
                    <asp:Parameter Name="original_TenDangNhap" Type="String" />
                    <asp:Parameter Name="original_MatKhau" Type="String" />
                    <asp:Parameter Name="original_HoTen" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                    <asp:Parameter Name="original_SoDienThoai" Type="String" />
                    <asp:Parameter Name="original_QuanTri" Type="Boolean" />
                    <asp:Parameter Name="original_TrangThai" Type="Boolean" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="TenDangNhap" Type="String" />
                    <asp:Parameter Name="MatKhau" Type="String" />
                    <asp:Parameter Name="HoTen" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="SoDienThoai" Type="String" />
                    <asp:Parameter Name="QuanTri" Type="Boolean" />
                    <asp:Parameter Name="TrangThai" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="TenDangNhap" Type="String" />
                    <asp:Parameter Name="MatKhau" Type="String" />
                    <asp:Parameter Name="HoTen" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="SoDienThoai" Type="String" />
                    <asp:Parameter Name="QuanTri" Type="Boolean" />
                    <asp:Parameter Name="TrangThai" Type="Boolean" />
                    <asp:Parameter Name="original_IDNguoiDung" Type="Int32" />
                    <asp:Parameter Name="original_TenDangNhap" Type="String" />
                    <asp:Parameter Name="original_MatKhau" Type="String" />
                    <asp:Parameter Name="original_HoTen" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                    <asp:Parameter Name="original_SoDienThoai" Type="String" />
                    <asp:Parameter Name="original_QuanTri" Type="Boolean" />
                    <asp:Parameter Name="original_TrangThai" Type="Boolean" />
                </UpdateParameters>
            </asp:SqlDataSource>--%>
        </div>
    </div>
</asp:Content>

