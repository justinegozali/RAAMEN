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
    public partial class Loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["usernameCookie"] != null && Request.Cookies["passwordCookie"] != null)
            {
                String username = Request.Cookies["usernameCookie"].Value;
                String password = Request.Cookies["passwordCookie"].Value;
                User user = UserController.loginAccount(username, password);
                Session["User"] = user;
                Response.Redirect("~/View/Homepage.aspx");
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;
            bool rememberMe = rememberMeCB.Checked;
            User user = UserController.loginAccount(username, password);
            if (user == null)
            {
                infoLbl.Text = "Wrong username or password";
            }
            else
            {
                Session["User"] = user;
                if (rememberMe == true)
                {
                    HttpCookie usernameCookie = new HttpCookie("usernameCookie");
                    usernameCookie.Value = username.Trim();
                    usernameCookie.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(usernameCookie);
                    HttpCookie passwordCookie = new HttpCookie("passwordCookie");
                    passwordCookie.Value = password.Trim();
                    passwordCookie.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(passwordCookie);
                }
                Response.Redirect("~/View/Homepage.aspx");
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Registerpage.aspx");
        }
    }
}