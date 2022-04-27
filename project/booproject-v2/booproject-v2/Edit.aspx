<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="booproject_v2.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="css/Styles.css" rel="stylesheet" runat="server"/>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h1>BOOProject</h1>
            <asp:Button ID="ReturnToIndex" OnClick="ReturnToIndex_Click" runat="server" Text="Vratit se na hlavni stranku"/>
            <br /><br />
            <p>
            <label>Edit: </label>
                <asp:DropDownList ID="DropDownList" runat="server">
                    <asp:ListItem Text="Skupina" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Album" Value="2"></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="nameinput" runat="server" />
                <asp:Button ID="confirmtype" runat="server" Text="Vyhledat" OnClick="confirmtype_Click"/>
            </p>
            <asp:TextBox ID="input1" runat="server" Visible="false" />
            <asp:TextBox ID="input2" runat="server" visible="false"/>
            <asp:TextBox ID="input3" runat="server" visible="false"/>
            <asp:TextBox ID="input4" runat="server" visible="false"/>
            <br />
            <asp:Button ID="confirmedit" runat="server" Text="Potvrdit" OnClick="confirmedit_Click"/>
        </div>
    </form>
</body>
</html>
