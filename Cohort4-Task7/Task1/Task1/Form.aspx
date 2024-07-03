<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Task1.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task Form</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f9;
        }

        form {
            width: 50%;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        div {
            margin-bottom: 15px;
        }

        label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        input[type="text"],
        textarea {
            width: calc(100% - 10px);
            padding: 10px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        input[type="text"]:focus,
        textarea:focus {
            border-color: #007bff;
        }

        .radio-buttons,
        .checkboxes {
            display: flex;
            gap: 15px;
            margin: 10px 0;
        }

        .radio-buttons label,
        .checkboxes label {
            font-weight: normal;
        }

        input[type="radio"],
        input[type="checkbox"] {
            margin-right: 5px;
        }

        button {
            display: inline-block;
            padding: 10px 20px;
            font-size: 16px;
            color: #fff;
            background-color: #007bff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        button:hover {
            background-color: #0056b3;
        }
        
        .radio-buttons,
        .checkboxes {
            display: flex;
            flex-direction: column;
        }

        .radio-buttons input[type="radio"],
        .checkboxes input[type="checkbox"] {
            margin-right: 10px;
        }

        .radio-buttons label,
        .checkboxes label {
            display: flex;
            align-items: center;
            font-weight: normal;
            margin-bottom: 5px;
        }
        #RadioButtonList1{
            display:flex;
            flex-direction:column;
        }

        .form-results {
            width: 50%;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .form-results div {
            margin-bottom: 15px;
        }

        .form-results label {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="TextBox1">Name:</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        </div>
        <div>
            <label for="TextBox2">Email:</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="TextBox3">ID:</label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
        <div class="radio-buttons">
            <label>Gender:</label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="checkboxes">
            <label>Course:</label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>C++</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <label for="TextArea1">Description:</label>
            <textarea id="TextArea1" cols="20" name="S1" rows="4"></textarea>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
    <div class="form-results">
        <div>
            <label>Name:</label>
            <asp:Label ID="NameLabel" runat="server"></asp:Label>
        </div>
        <div>
            <label>Email:</label>
            <asp:Label ID="EmailLabel" runat="server"></asp:Label>
        </div>
        <div>
            <label>ID:</label>
            <asp:Label ID="IDLabel" runat="server"></asp:Label>
        </div>
        <div>
            <label>Gender:</label>
            <asp:Label ID="GenderLabel" runat="server"></asp:Label>
        </div>
        <div>
            <label>Course:</label>
            <asp:Label ID="CourseLabel" runat="server"></asp:Label>
        </div>
        <div>
            <label>Description:</label>
            <asp:Label ID="DescriptionLabel" runat="server"></asp:Label>
        </div>
    </div>
</body>
</html>
