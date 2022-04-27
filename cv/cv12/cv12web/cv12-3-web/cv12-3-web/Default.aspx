<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cv12_3_web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="OperandA" runat="server"></asp:TextBox>
            <asp:DropDownList ID="Operace" runat="server">
                <asp:ListItem Text="+" Value="+"></asp:ListItem>
                <asp:ListItem Text="-" Value="-"></asp:ListItem>
                <asp:ListItem Text="*" Value="*"></asp:ListItem>
                <asp:ListItem Text="/" Value="/"></asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="OperandB" runat="server"></asp:TextBox>
            <asp:Button ID="Button" runat="server" Text="Button" OnClick ="Button_click"/>
        </div>
    </form>
</body>
</html>
