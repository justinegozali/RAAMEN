using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class InsertRamenpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamenpage.aspx");
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            String name = nameTxt.Text;
            String meat = meatLst.SelectedValue;
            String broth = brothTxt.Text;
            String price = priceTxt.Text;

            infoLbl.Text = RamenController.insertRamen(meat, name, broth, price);

            if (infoLbl.Text.Equals("Insert Success"))
            {
                Response.Redirect("~/View/ManageRamenpage.aspx");
            }
        }
    }
}