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
    public partial class UpdateRamenpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Raman ramen = RamenController.getRamenBasedOnId(id);
            String meat = MeatController.getMeatBasedOnId((int)ramen.MeatId);

            nameLbl.Text = ramen.Name;
            meatLbl.Text = meat;
            brothLbl.Text = ramen.Broth;
            priceLbl.Text = ramen.Price;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            String name = nameTxt.Text;
            String meat = meatLst.SelectedValue;
            String broth = brothTxt.Text;
            String price = priceTxt.Text;

            infoLbl.Text = RamenController.updateRamen(id, meat, name, broth, price);

            if (infoLbl.Text.Equals("Update Success"))
            {
                Response.Redirect("~/View/ManageRamenpage.aspx");
            }
        }
    }
}