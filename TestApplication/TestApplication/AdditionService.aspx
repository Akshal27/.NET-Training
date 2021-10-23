<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdditionService.aspx.cs" Inherits="TestApplication.AdditionService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number 1:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Number 2:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Result:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Addition" />
            <asp:Button ID="Button2" runat="server" Text="Multiplication" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Division" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Subtraction" OnClick="Button4_Click" />
            <br />
            <br />
            Student Name:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Student Age;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            Student Course:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="DisplayName" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
