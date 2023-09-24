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
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;
            if (role == 1)
            {
                btn1.Text = "Manage Ramen";
                btn2.Text = "Order Queue";
                btn3.Text = "Profile";
                btn4.Text = "History";
                btn5.Text = "Report";
                btn6.Text = "Logout";
            }
            else if (role == 2)
            {
                btn1.Text = "Manage Ramen";
                btn2.Text = "Order Queue";
                btn3.Text = "Profile";
                btn4.Text = "Logout";
                btn5.Visible = false;
                btn6.Visible = false;
            }
            else if (role == 3)
            {
                btn1.Text = "Order Ramen";
                btn2.Text = "History";
                btn3.Text = "Profile";
                btn4.Text = "Logout";
                btn5.Visible = false;
                btn6.Visible = false;
            }
        }
        protected void manageRamen()
        {
            Response.Redirect("~/View/ManageRamenpage.aspx");
        }
        protected void orderRamen()
        {
            Response.Redirect("~/View/OrderRamenpage.aspx");
        }
        protected void orderQueue()
        {
            Response.Redirect("~/View/TransactionQueue.aspx");
        }
        protected void profile()
        {
            Response.Redirect("~/View/Profilepage.aspx");
        }
        protected void history()
        {
            Response.Redirect("~/View/History.aspx");
        }
        protected void report()
        {
            Response.Redirect("~/View/Reportpage.aspx");
        }
        protected void logout()
        {
            Response.Cookies["usernameCookie"].Expires = DateTime.Now.AddDays(-31);
            Response.Cookies["passwordCookie"].Expires = DateTime.Now.AddDays(-31);
            Session["User"] = "";
            Response.Redirect("~/View/Loginpage.aspx");
        }
        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Homepage.aspx");
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;
            if (role == 1)
            {
                manageRamen();
            }
            else if (role == 2)
            {
                manageRamen();
            }
            else if (role == 3)
            {
                orderRamen();
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;
            if (role == 1)
            {
                orderQueue();
            }
            else if (role == 2)
            {
                orderQueue();
            }
            else if (role == 3)
            {
                history();
            }
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            profile();
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;
            if (role == 1)
            {
                history();
            }
            else if (role == 2)
            {
                logout();
            }
            else if (role == 3)
            {
                logout();
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;
            if (role == 1)
            {
                report();
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int role = (int)user.RoleId;
            if (role == 1)
            {
                logout();
            }
        }
    }
}