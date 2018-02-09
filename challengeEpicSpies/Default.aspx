<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <br />
            <h2>Spy New Assignment Form</h2>
            <br />
            Spy Code Name:
            <asp:TextBox ID="spyCodeNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="previousAssignmentEndCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Start Date of New Assignment:<br />
            <asp:Calendar ID="newAssignmentStartCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Projected End Date of New Assignment:<br />
            <asp:Calendar ID="newAssignmentEndCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="messageLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
