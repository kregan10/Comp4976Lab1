<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CompoundInterest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Compound interest calculator</h1>
            <asp:Label ID="principal" runat="server" Text="Principle Investment" />
            <br />
            <asp:TextBox ID="principalInvestment" runat="server" />
            <br />

            <asp:Label ID="interest" runat="server" Text="Interest Rate" />
            <br />
            <asp:TextBox ID="interestRate" runat="server" />
            <br />

            <asp:Label ID="compoundedYearly" runat="server" Text="Number of times compounded per year" />
            <br />

            <asp:TextBox ID="numOfCompoundsPerYear" runat="server" />
            <br />

            <asp:Label ID="duration" runat="server" Text="Number of Years" />
            <br />

            <asp:TextBox ID="numOfYears" runat="server" />
            <br />
        </div>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <br />

            <asp:Label ID="lblResult" runat="server"></asp:Label>

    </form>

</body>
</html>
