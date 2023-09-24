using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class ManageRamenpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RamenGV.DataSource = RamenController.getAllRamen();
            RamenGV.DataBind();
            
            int loop = RamenController.getAllRamen().Count;
            for (int i = 0; i < loop; i++)
            {
                RamenGV.Rows[i].Cells[2].Text = MeatController.getMeatBasedOnId(int.Parse(RamenGV.Rows[i].Cells[2].Text));
            }
            
        }

        protected void insertRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertRamenpage.aspx");
        }

        protected void userGv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = RamenGV.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            Response.Redirect("~/View/UpdateRamenpage.aspx?id=" + id);
        }

        protected void userGv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = RamenGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);
            RamenController.deleteRamen(id);
            Response.Redirect("~/View/ManageRamenpage.aspx");
        }
    }
}