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
            if (ValidateFields())
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

        // Helper methods

        public bool ValidateFields()
        {
            if (sizeDropDownList.SelectedIndex == 0)
            {
                errorLabel.Text = "Please select a pizza size.";
                errorLabel.Visible = true;
                return false;
            }

            if (crustDropDownList.SelectedIndex == 0)
            {
                errorLabel.Text = "Please select a crust.";
                errorLabel.Visible = true;
                return false;
            }

            if (nameTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter your name.";
                errorLabel.Visible = true;
                return false;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter your address.";
                errorLabel.Visible = true;
                return false;
            }

            if (zipTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter your zip code.";
                errorLabel.Visible = true;
                return false;
            }

            if (phoneNumberTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter your phone number.";
                errorLabel.Visible = true;
                return false;
            }

            return true;
        }
    }
}