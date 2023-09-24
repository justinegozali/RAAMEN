using RAAMEN.Model;
using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;

            usernameLbl.Text = user.Username;

            customerGV.DataSource = UserController.getAllCustomer();
            customerGV.DataBind();
            int loop1 = UserController.getAllCustomer().Count;
            for (int i = 0; i < loop1; i++)
            {
                customerGV.Rows[i].Cells[1].Text = "Customer";
            }

            staffGV.DataSource = UserController.getAllStaff();
            staffGV.DataBind();
            int loop2 = UserController.getAllStaff().Count;
            for (int i = 0; i < loop2; i++)
            {
                staffGV.Rows[i].Cells[1].Text = "Staff";
            }

            if(role == 1)
            {
                roleLbl.Text = "Admin";
            }
            else if(role == 2)
            {
                roleLbl.Text = "Staff";
                staffGV.Visible = false;
            }
            else if(role == 3)
            {
                roleLbl.Text = "Customer";
                customerGV.Visible = false;
                staffGV.Visible = false;
            }
        }
    }
}