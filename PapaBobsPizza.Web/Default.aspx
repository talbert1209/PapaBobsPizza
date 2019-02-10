﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsPizza.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- This is the page header  -->
            <div class="pb-2 mt-4 mb-2 border-bottom">
                <h1>Papa Bob's Pizza</h1>
                <p class="lead">Pizza to code by</p>
            </div>

            <!-- Build your pizza section  -->
            <h4>Build your pizza</h4>
            <div class="form-group">
                <label>Size:</label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>Option 1</asp:ListItem>
                    <asp:ListItem>Option 2</asp:ListItem>
                    <asp:ListItem>Option 3</asp:ListItem>
                    <asp:ListItem>Option 4</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label>Crust:</label>
                <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>Option 1</asp:ListItem>
                    <asp:ListItem>Option 2</asp:ListItem>
                    <asp:ListItem>Option 3</asp:ListItem>
                    <asp:ListItem>Option 4</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server"></asp:CheckBox> Sausage</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server"></asp:CheckBox> Pepperoni</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server"></asp:CheckBox> Onions</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server"></asp:CheckBox> Green Peppers</label></div>
            
            <!-- Delivery information -->
            <h4>Deliver to:</h4>
            <div class="form-group">
                <label>Name</label>
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Address</label>
                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Zip Code</label>
                <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Phone Number</label>
                <asp:TextBox ID="phoneNumberTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <!-- Payment information -->
            <h4>Payment information</h4>
            <div class="custom-checkbox"><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentRadioButtons" /><label> Cash</label></div>
            <div class="custom-checkbox"><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="paymentRadioButtons" /><label> Credit</label></div>
            
            <!-- Order button -->
            <asp:Button ID="orderButton" runat="server" Text=" Order " CssClass="btn btn-primary"/>
            <br />
            <h3>Order Total: </h3>
            <br/>
        </div>
    </form>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
