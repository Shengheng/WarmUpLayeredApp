<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LongToShort.aspx.cs" Inherits="UIPerson.LongToShort" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Age" runat="server" />
            <asp:TextBox runat="server" ID="txtAge" />
            <asp:RequiredFieldValidator ID="txtAgeRqrVld" ErrorMessage="Please type an integer as Age" ControlToValidate="txtAge" runat="server" />
            <asp:RangeValidator ErrorMessage="Input out of range" ControlToValidate="txtAge" runat="server" MaximumValue="150" MinimumValue="1" ForeColor="Red" Type="Integer" />
            <br />
            <asp:Button Text="Submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" CausesValidation="true" />
            <br />
            <asp:Label Text="SqlServerCurrentTime" runat="server" />
            <asp:TextBox runat="server" ID="txtTime" />
            <br />
            <asp:GridView runat="server" ID="gvPersonL"></asp:GridView>
            <asp:Label Text="AffectedRows" runat="server" />
            <asp:TextBox runat="server" ID="txtRows" />
            <br />
            <asp:Label Text="" ID="lblMessage" runat="server" />
        </div>
    </form>
</body>
</html>
