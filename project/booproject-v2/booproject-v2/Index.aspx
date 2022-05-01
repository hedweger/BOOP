<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="booproject_v2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BOOProject</title>
    <link href="css/Styles.css" rel="stylesheet" runat="server"/>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h1>BOOProject</h1>
            <asp:Button CssClass="indexButton" ID="AddGroup" OnClick="AddGroup_Click" runat="server" Text="Pridat skupinu"/>
             <asp:Button CssClass="indexButton" ID="AddAlbum" OnClick="AddAlbum_Click" runat="server" Text="Pridat album"/>
            <asp:Button CssClass="indexButton" ID="Edit" OnClick="Edit_Click" runat="server" Text="Editovat"/>
            <br />
            <asp:Button CssClass="indexButton" ID="WriteCSV" OnClick="WriteCSV_Click" runat="server" Text="Export CSV" />
            <asp:Button CssClass="indexButton" ID="ReadCSV" OnClick="ReadCSV_Click" runat="server" Text="Import CSV"/>
            <br />
            <asp:TextBox ID="SearchInput" runat="server"></asp:TextBox>
            <asp:Button CssClass="indexButton" ID="Search" OnClick="Search_Click" runat="server" Text="Vyhledat"/>
            <br />
            <br />
            <asp:GridView GridLines="Horizontal" CssClass="basicGrid" ID="GridViewSearch" runat="server" AllowPaging="true" HorizontalAlign="Center">
                <RowStyle CssClass="basicRow" />
                <HeaderStyle CssClass="basicHeader"/>
            </asp:GridView>
            <br />
            <hr />
            <p>Výpis všech hodnot v databázi (ukazují se jenom skupinz které mají přiřazeno aspon jedno album): </p>
            <asp:GridView GridLines="horizontal" CssClass="basicGrid" ID="GridViewAll" runat="server" AllowPaging="true" HorizontalAlign="Center">
               <RowStyle CssClass="basicRow" />
                <HeaderStyle CssClass="basicHeader"/>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
