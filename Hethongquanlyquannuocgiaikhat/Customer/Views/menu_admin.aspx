<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu_admin.aspx.cs" Inherits="Customer_Views_menu_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Chọn bàn:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Chọn loại:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged1">
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" SortExpression="name" />
                <asp:BoundField DataField="price" HeaderText="price" ReadOnly="True" SortExpression="price" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
