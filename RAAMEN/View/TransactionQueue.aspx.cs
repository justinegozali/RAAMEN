using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class TransactionQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            headerGV.DataSource = HeaderController.getUnhandledHeader();
            headerGV.DataBind();
        }
        protected void headerGV_SelectRow(object sender, GridViewSelectEventArgs e)
        {
            User user = (User)Session["User"];
            GridViewRow row = headerGV.Rows[e.NewSelectedIndex];
            int id = int.Parse(row.Cells[1].Text);
            HeaderController.handleHeader(id, user.Id);

            headerGV.DataSource = HeaderController.getUnhandledHeader();
            headerGV.DataBind();
        }
    }
}