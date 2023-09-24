using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Registerpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerAsBuyerBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String gender = genderLst.SelectedValue;
            String password = passwordTxt.Text;
            String confirmPassword = confirmPasswordTxt.Text;

            infoLbl.Text = UserController.insertUser(3, username, email, gender, password, confirmPassword);

            if (infoLbl.Text.Equals("Insert Success"))
            {
                Response.Redirect("~/View/Loginpage.aspx");
            }
        }

        protected void registerAsSellerBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String gender = genderLst.SelectedValue;
            String password = passwordTxt.Text;
            String confirmPassword = confirmPasswordTxt.Text;

            infoLbl.Text = UserController.insertUser(2, username, email, gender, password, confirmPassword);

            if (infoLbl.Text.Equals("Insert Success"))
            {
                Response.Redirect("~/View/Loginpage.aspx");
            }
        }
    }
}