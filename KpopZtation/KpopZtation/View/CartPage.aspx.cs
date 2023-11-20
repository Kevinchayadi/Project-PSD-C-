using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        AlbumHandler th = new AlbumHandler();
        CartHandler cart = new CartHandler();
        List<Album> album = new List<Album>();
        TransactionHandler tr = new TransactionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            List<Cart> data = cart.FindID(custo.CustomerID);

            album = th.GetData(data);
            GridView1.DataSource = album;
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            String name = row.Cells[1].Text;
            Album data = album.Find(album => album.AlbumName == name);
            album.Remove(data);
            Response.Redirect("CartPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            foreach (Album data in album)
            {
                tr.AddData(custo.CustomerID, data.AlbumID, data.AlbumStock, DateTime.Now);
                album.Remove(data);
            }
            Response.Redirect("TransactionPage.aspx?id=" + custo.CustomerID);

        }
    }
}