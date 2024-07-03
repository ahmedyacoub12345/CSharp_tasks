<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Cohort4_Task7.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
            <br />
            <br />
            <label>Number 1:</label>
            <asp:TextBox ID="Number1" runat="server"></asp:TextBox>
            <br />
            <br />
            <label>Number 2:</label>
            <asp:TextBox ID="Number2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="AddButton" runat="server" Text="+" OnClick="AddButton_Click" />
            <asp:Button ID="SubtractButton" runat="server" Text="-" OnClick="SubtractButton_Click" />
            <asp:Button ID="MultiplyButton" runat="server" Text="*" OnClick="MultiplyButton_Click" />
        </div>
    </form>
</body>
</html>
