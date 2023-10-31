<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LIST.aspx.cs" Inherits="ASPASSIGNMENT.LIST" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <h1>Select a Bike Model:</h1>
            <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                <asp:ListItem Text="Select a Bike" Value="0" />
                <asp:ListItem Text="KTM" Value="1"  />
                <asp:ListItem Text="M_15" Value="2"  />
                <asp:ListItem Text="ROYAL_ENFIELD" Value="3"  />
                <asp:ListItem Text="PULSAR" Value="4"  />

            </asp:DropDownList>
            <br /><br />

            <asp:Image ID="imgItem"  runat="server" ImageUrl="Images/default.jfif" Width="200" Height="200" />

            <br /><br />

            <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
            <br /><br />

            <asp:Label ID="lblCost" runat="server" Text="" />
        </div>
    </form>
</body>
</html>