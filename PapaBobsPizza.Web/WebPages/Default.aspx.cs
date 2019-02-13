using System;
using System.Collections.Generic;
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
                TotalCost = Convert.ToDecimal(totalCostLabel.Text)
            };

            Domain.OrdersManager.AddOrder(newOrder);
        }

        private void ClearFields()
        {
            
        }
    }
}