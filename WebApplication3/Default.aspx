<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="trading_calculator.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Trading Calculator</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
        }

        .container {
            width: 400px;
            margin: auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.2);
        }

        h2 {
            text-align: center;
            color: #333;
        }

        .btn {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border: none;
            border-radius: 5px;
            color: white;
            cursor: pointer;
        }

        .calculate {
            background-color: #28a745;
        }

        .reset {
            background-color: #dc3545;
        }

        .switch {
            background-color: #007bff;
        }

        input[type="text"] {
            width: 100%;
            padding: 8px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2><asp:Label ID="lblTitle" runat="server" Text="Trading Calculator"></asp:Label></h2>

            <asp:Label ID="lbl1" runat="server" Text="Current Price:" /><br />
            <asp:TextBox ID="txtPrice" runat="server" /><br />

            <asp:Label ID="lbl2" runat="server" Text="Percent Profit:" /><br />
            <asp:TextBox ID="txtProfit" runat="server" /><br />

            <asp:Label ID="lbl3" runat="server" Text="Target Price:" /><br />
            <asp:TextBox ID="txtTarget" runat="server" ReadOnly="True" /><br />

            <asp:Label ID="lbl4" runat="server" Text="Difference:" /><br />
            <asp:TextBox ID="txtDifference" runat="server" ReadOnly="True" /><br />

            <asp:Button ID="btnCalculate" runat="server" CssClass="btn calculate" Text="Calculate" OnClick="btnCalculate_Click" />
            <asp:Button ID="btnReset" runat="server" CssClass="btn reset" Text="Reset" OnClick="btnReset_Click" />
            <asp:Button ID="btnSwitch" runat="server" CssClass="btn switch" Text="Switch to Percent Profit" OnClick="btnSwitch_Click" />
        </div>
    </form>
</body>
</html>
