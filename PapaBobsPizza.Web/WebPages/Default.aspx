<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsPizza.Web.WebPages.Default" %>

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
                <p class="lead">Pizza to code by</p>
            </div>

            <!-- Build your pizza section  -->
            <h4>Build your pizza</h4>
            <div class="form-group">
                <label>Size:</label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="CalculatePrice">
                    <asp:ListItem>Select a size...</asp:ListItem>
                    <asp:ListItem>Small (12 inch - $12)</asp:ListItem>
                    <asp:ListItem>Medium (14 inch - $14)</asp:ListItem>
                    <asp:ListItem>Large (16 inch - $16)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label>Crust:</label>
                <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="CalculatePrice">
                    <asp:ListItem>Select a crust...</asp:ListItem>
                    <asp:ListItem>Regular</asp:ListItem>
                    <asp:ListItem>Thin</asp:ListItem>
                    <asp:ListItem>Thick (+ $2)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="CalculatePrice"></asp:CheckBox> Sausage</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="CalculatePrice"></asp:CheckBox> Pepperoni</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="CalculatePrice"></asp:CheckBox> Onions</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="CalculatePrice"></asp:CheckBox> Green Peppers</label></div>
            
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
            <asp:RadioButtonList ID="paymentTypeRadioButtonList" runat="server">
                <asp:ListItem Text ="Cash" Value="Cash" />
                <asp:ListItem Text ="Credit" Value="Credit" />
            </asp:RadioButtonList>
            
            <!-- Order button -->
            <asp:Button ID="orderButton" runat="server" Text=" Order " CssClass="btn btn-primary" OnClick="orderButton_Click"/> &nbsp; &nbsp;
            <asp:Label ID="errorLabel" runat="server" Text="" Visible="False" class="alert alert-danger"></asp:Label>
            <br/>
            <h3>Order Total: 
            <asp:Label ID="totalCostLabel" runat="server" Text=""></asp:Label>
            </h3>
            
        </div>
    </form>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
