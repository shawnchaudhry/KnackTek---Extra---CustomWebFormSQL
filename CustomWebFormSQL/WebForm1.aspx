<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CustomWebFormSQL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Name:
        <asp:TextBox ID="tbFirst" runat="server"></asp:TextBox>
        <br />
        Last Name:
        <asp:TextBox ID="tbLast" runat="server"></asp:TextBox>
        <br />
        Address:
        <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
        <br />
        City:<asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
        <br />
        State:<asp:TextBox ID="tbState" runat="server"></asp:TextBox>
        <br />
        Zip:<asp:TextBox ID="tbZip" runat="server"></asp:TextBox>
        <br />
        Credit Card Number:<asp:TextBox ID="tbCreditCard" runat="server"></asp:TextBox>
        <br />
        Expiration:
        <asp:TextBox ID="tbExp" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnWrite" runat="server" Text="Write To SQL Database" OnClick="writeToDatabase" />
    
    </div>
    </form>
</body>
</html>
