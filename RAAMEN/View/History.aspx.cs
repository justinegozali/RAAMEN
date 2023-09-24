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
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;

            if (role == 1)
            {
                headerGV.DataSource = HeaderController.getAllHeader();
                headerGV.DataBind();
            }
            else if (role == 3)
            {
                headerGV.DataSource = HeaderController.getHeaderBasedOnId(user.Id);
                headerGV.DataBind();
            }
        }

        protected void headerGV_SelectRow(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = headerGV.Rows[e.NewSelectedIndex];
            int id = int.Parse(row.Cells[1].Text);
            Response.Redirect("~/View/TransactionDetailpage.aspx?id=" + id);
        }
    }
}