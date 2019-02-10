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
            PBPizzaDBEntities db = new PBPizzaDBEntities();
            var orders = db.Orders;

            OrdersGridView.DataSource = orders.ToList();
            OrdersGridView.DataBind();
        }
    }
}