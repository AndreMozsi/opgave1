<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="opgave1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welkom</h1>
                <p>Naam:</p>
                <asp:TextBox ID="txtNaam" runat="server" placeholder="vul naam hier in" required></asp:TextBox>
                <p>Geslacht:</p>
                 <asp:RadioButtonList ID="rbtnGeslacht" runat="server">
                <asp:ListItem Value="M">M</asp:ListItem>
                <asp:ListItem Value="V">V</asp:ListItem>
                <asp:ListItem Value="X" Selected="True">X</asp:ListItem>
            </asp:RadioButtonList><br />
                <asp:Button ID="btnGa" runat="server" Text="Ga!" OnClick="btnGa_Click" />
        </div>
    </form>
</body>
</html>
