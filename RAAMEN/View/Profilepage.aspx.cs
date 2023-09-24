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
    public partial class Profilepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            usernameLbl.Text = user.Username;
            emailLbl.Text = user.Email;
            genderLbl.Text = user.Gender;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String gender = genderLst.SelectedValue;
            String password = passwordTxt.Text;

            infoLbl.Text = UserController.updateUser(user.Id, username, email, gender, password);
            if (infoLbl.Text == "Update Success")
            {
                Response.Redirect("~/View/Profilepage.aspx");
            }
        }
    }
}