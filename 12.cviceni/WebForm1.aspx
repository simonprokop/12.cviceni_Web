<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_12.cviceni.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="Operand1" runat="server"></asp:TextBox>
		<asp:DropDownList ID="Operace" runat="server">
			<asp:ListItem>+</asp:ListItem>
			<asp:ListItem>-</asp:ListItem>
			<asp:ListItem>*</asp:ListItem>
			<asp:ListItem Value="/"></asp:ListItem>
		</asp:DropDownList>
		<asp:TextBox ID="Operand2" runat="server"></asp:TextBox>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Spocti" />
		<asp:TextBox ID="Vysledek" runat="server"></asp:TextBox>
    </form>
</body>
</html>
