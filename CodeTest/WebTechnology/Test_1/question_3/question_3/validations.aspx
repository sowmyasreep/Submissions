<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validations.aspx.cs" Inherits="validations.Validator" %>
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Validation Form</h1>
        <div>
            <label for="txtName">Name:</label> sowmya</div>
        <div>
            <label for="txtFamilyName">Family Name:</label> sree</div>
        <div>
            <label for="txtAddress">Address:</label> hb apartment</div>
        <div>
            <label for="txtCity">City:</label> vizag</div>
        <div>
            <label for="txtZipCode">Zip Code:</label>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtPhone">Phone:</label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
        </div>
    </form>
</body>
</html>