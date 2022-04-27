<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddGroup.aspx.cs" Inherits="booproject_v2.AddGroup" %>

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
                <p><label>Jmeno skupiny: </label>
                <asp:TextBox ID="groupnameinput" runat="server" />
                </p>
                <p><label>Pocet clenu: </label>
                <asp:TextBox ID="membersinput" runat="server" />
                </p>
                <br />
                <asp:Button ID="Submit" OnClick="Submit_Click" runat="server" Text="Potvrdit" />
                <br />
                <asp:PlaceHolder ID="confirmgroup" runat="server"></asp:PlaceHolder>
                <br />
                <p><label> Databaze skupin: </label></p>
                <asp:GridView GridLines="horizontal" CssClass="basicGrid" ID="GridViewGroup" runat="server" AllowPaging="true">
                    <RowStyle CssClass="basicRow" />
                    <HeaderStyle CssClass="basicHeader"/>
                </asp:GridView>
           
        </div>
    </form>
</body></html>
