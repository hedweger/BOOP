<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAlbum.aspx.cs" Inherits="booproject_v2.AddAlbum" %>

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
            <p><label>Jmeno alba: </label>
            <asp:TextBox ID="albumnameinput" runat="server" />
            </p>
            <p><label>Zanr: </label>
            <asp:TextBox ID="genreinput" runat="server" />
            </p>
            <p><label>Rok vydani: </label>
            <asp:TextBox ID="releaseinput" runat="server" />
            </p>
            <p><label>Pocet pisnicek: </label>
            <asp:TextBox ID="tracksinput" runat="server" />
            </p>
            <p><label>Priradit album ke skupine:  </label>
            <asp:TextBox ID="groupnameinut" runat="server" />
            </p>
            <br />
            <asp:Button ID="Submit" OnClick="Submit_Click" runat="server" Text="Potvrdit" />
            <br />
            <asp:PlaceHolder ID="confirmalbum" runat="server"></asp:PlaceHolder>
            <br />
            <asp:PlaceHolder ID="confirmconnection" runat="server"></asp:PlaceHolder>
            <br />
            <p><label> Databaze alb: </label></p>
            <asp:GridView GridLines="horizontal" CssClass="basicGrid" ID="GridViewAlbum" runat="server" AllowPaging="true" HorizontalAlign="Center">
                <RowStyle CssClass="basicRow" />
                <HeaderStyle CssClass="basicHeader"/>
            </asp:GridView>
     
        </div>
    </form>
</body>
</html>
