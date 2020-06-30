<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FTAaryamanChaudhry.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSearchByID" runat="server" Text="Enter ID of Publisher"></asp:Label>
            <asp:TextBox ID="txtSearchPublisherByID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validatePublisherID" runat="server" ControlToValidate="txtSearchPublisherByID" ErrorMessage="*This field is required"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="btnSearchPublisherByID" runat="server" Text="Search Publisher" OnClick="btnSearchPublisherByID_Click" />
    </form>
</body>
</html>
