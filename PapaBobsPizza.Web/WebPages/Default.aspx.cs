using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            var newOrder = new DTO.Order
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

            Domain.OrdersManager.AddOrder(newOrder);
        }

        protected void CalculatePrice(object sender, EventArgs e)
        {
            totalCostLabel.Text = Domain.PizzaPrice.CalculateTotal(sizeDropDownList.SelectedIndex, crustDropDownList.SelectedIndex, 
                sausageCheckBox.Checked, pepperoniCheckBox.Checked, onionsCheckBox.Checked, greenPeppersCheckBox.Checked).ToString("C");
        }
    }
}