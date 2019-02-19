<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PapaBobsPizza.Web.WebPages.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- This is the page header  -->
            <div class="pb-2 mt-4 mb-2 border-bottom">
                <h1>Papa Bob's Pizza</h1>
                <p class="lead">Order Management</p>
            </div>
            
            <!-- This is the grid -->
            <asp:GridView ID="OrdersGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:ButtonField Text=" Complete " />
                    <asp:BoundField DataField="OrderID" HeaderText=" Order ID " />
                    <asp:BoundField DataField="Name" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Size" HeaderText=" Pizza Size " />
                    <asp:BoundField DataField="Crust" HeaderText=" Crust Type " />
                    <asp:CheckBoxField DataField="Sausage" HeaderText=" Sausage " />
                    <asp:CheckBoxField DataField="Pepperoni" HeaderText=" Pepperoni " />
                    <asp:CheckBoxField DataField="Onions" HeaderText=" Onions " />
                    <asp:CheckBoxField DataField="GreenPeppers" HeaderText=" Green Peppers " />
                    <asp:CheckBoxField DataField="Completed" HeaderText=" Complete? " />
                    <asp:BoundField DataField="TotalCost" HeaderText="Total Price" SortExpression="TotalCost" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
