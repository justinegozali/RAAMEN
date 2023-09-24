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
    public partial class OrderRamenpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            RamenGV.DataSource = RamenController.getAllRamen();
            RamenGV.DataBind();
            
            int loop = RamenController.getAllRamen().Count;
            for (int i = 0; i < loop; i++)
            {
                int meatId = int.Parse(RamenGV.Rows[i].Cells[1].Text);
                String text = MeatController.getMeatBasedOnId(meatId);
                RamenGV.Rows[i].Cells[1].Text = text;
            }
            
            CartGV.DataSource = CartController.getCart(user.Id);
            if (CartGV.Columns.Count == 3)
            {
                CartGV.Columns.RemoveAt(0);
            }
            CartGV.DataBind();
        }

        protected void addCartBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            String ramenId = menuIdTxt.Text;
            String quantity = quantityTxt.Text;

            infoLbl.Text = CartController.insertCart(user.Id, ramenId, quantity);

            CartGV.DataSource = CartController.getCart(user.Id);
            CartGV.DataBind();
        }

        protected void clearCartBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            infoLbl.Text = CartController.clearCart(user.Id);

            CartGV.DataSource = CartController.getCart(user.Id);
            CartGV.DataBind();
        }

        protected void buyCartBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            Header header = HeaderController.insertHeader(user.Id);
            List<Cart> cart = CartController.getCart(user.Id);
            infoLbl.Text = DetailController.insertDetail(header.Id, cart);
            String text = CartController.clearCart(user.Id);

            CartGV.DataSource = CartController.getCart(user.Id);
            CartGV.DataBind();
        }
    }
}