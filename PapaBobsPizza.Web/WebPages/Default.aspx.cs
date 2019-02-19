using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaBobsPizza.Domain;
using PapaBobsPizza.DTO;

namespace PapaBobsPizza.Web.WebPages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //totalCostLabel.Text = Domain.PizzaPrice.CalculateTotal(sizeDropDownList.SelectedIndex, crustDropDownList.SelectedIndex, sausageCheckBox.Checked, 
            //    pepperoniCheckBox.Checked, onionsCheckBox.Checked, greenPeppersCheckBox.Checked).ToString("C");
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newOrder = new Order
                {
                    Size = sizeDropDownList.Text,
                    Crust = crustDropDownList.Text,
                    Sausage = sausageCheckBox.Checked,
                    Pepperoni = pepperoniCheckBox.Checked,
                    Onions = onionsCheckBox.Checked,
                    GreenPeppers = greenPeppersCheckBox.Checked,
                    Name = nameTextBox.Text,
                    Address = addressTextBox.Text,
                    ZipCode = zipTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                    PaymentType = paymentTypeRadioButtonList.SelectedValue,
                    TotalCost = decimal.Parse(totalCostLabel.Text, NumberStyles.Currency)
                };


                OrdersManager.AddOrder(newOrder);
                Response.Redirect("Success.html");
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.Visible = true;
            }
        }

        protected void CalculatePrice(object sender, EventArgs e)
        {
            totalCostLabel.Text = Domain.PizzaPrice.CalculateTotal(sizeDropDownList.SelectedIndex, crustDropDownList.SelectedIndex, 
                sausageCheckBox.Checked, pepperoniCheckBox.Checked, onionsCheckBox.Checked, greenPeppersCheckBox.Checked).ToString("C");
        }
    }
}