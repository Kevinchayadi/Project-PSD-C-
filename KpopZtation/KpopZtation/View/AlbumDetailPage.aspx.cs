using KpopZtation.Handler;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class AlbumDetailPage : System.Web.UI.Page
    {
        AlbumRepository th = new AlbumRepository();
        CartHandler cart = new CartHandler();
        Album data = new Album();
        protected void Page_Load(object sender, EventArgs e)
        {
            String Id = Request.QueryString["id"];
            Customer custo = (Customer)Session["user"];
            if (Id != null)
            {
                data = th.findAlbumById(Convert.ToInt32(Id));
                AlbumName.Text = data.AlbumName;
                Albumdesc.Text = data.AlbumDescription;
                AlbumPrice.Text = data.AlbumPrice.ToString();
                AlbumStock.Text = data.AlbumStock.ToString();
            }


            if (custo != null)
            {
                if (custo.CustomerRole == "Custo")
                {
                    input.Visible = true;
                }
            }


        }
        protected void Button1_Load(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            if (custo != null)
            {
                if (custo.CustomerRole == "Customer")
                {
                    Button1.Visible = true;
                }
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            if (input.Text != null)
            {
                if (Regex.IsMatch(input.Text, "[0-9]") == true)
                {
                    if (data.AlbumStock >= Convert.ToInt32(input.Text))
                    {
                        notif.Text = cart.adddata(custo.CustomerID, data.AlbumID, Convert.ToInt32(input.Text));
                    }
                }
            }
        }

    }
}