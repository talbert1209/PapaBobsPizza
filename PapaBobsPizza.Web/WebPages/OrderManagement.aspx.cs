using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsPizza.Web.WebPages
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var orders = Domain.OrdersManager.GetOrders();

            OrdersGridView.DataSource = orders;
            OrdersGridView.DataBind();
        }

        protected void OrdersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = OrdersGridView.Rows[index];
            var value = row.Cells[1].Text.ToString();
            var orderId = Convert.ToInt32(value);

            Domain.OrdersManager.CompleteOrder(orderId);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var orders = Domain.OrdersManager.GetOrders();

            OrdersGridView.DataSource = orders;
            OrdersGridView.DataBind();
        }
    }
}