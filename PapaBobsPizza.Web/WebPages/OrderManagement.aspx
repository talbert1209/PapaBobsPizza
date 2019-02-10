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
            <asp:GridView ID="OrdersGridView" runat="server"></asp:GridView>
        </div>
    </form>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
