<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CalcWebApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNumber1" runat="server" Text="Number 1"></asp:Label>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblNumber2" runat="server" Text="Number 2"></asp:Label>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
        </p>
        Operator<asp:DropDownList ID="ddlOperator" runat="server">
            <asp:ListItem>Add</asp:ListItem>
            <asp:ListItem>Sub</asp:ListItem>
            <asp:ListItem>Div</asp:ListItem>
            <asp:ListItem>Mul</asp:ListItem>
        </asp:DropDownList>
        <br/>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Calculate And Save" OnClick="Button1_Click" />
        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" Style="margin-left:5px" />
        <p>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CalcConnectionString %>" SelectCommand="SELECT * FROM [DiagnosticsDetails]"></asp:SqlDataSource>
    </form>
</body>
</html>
