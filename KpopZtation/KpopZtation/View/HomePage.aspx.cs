using KpopZtation.Handler;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        ArtistHandler th = new ArtistHandler();
        ArtistRepository tr = new ArtistRepository();
        Artist data = new Artist();
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            GridView1.Columns[2].Visible = false;
            if (custo != null)
            {
                if (custo.CustomerRole == "Admin")
                {
                    GridView1.Columns[2].Visible = true;
                }
            }
            List<Artist> data = tr.GetAllArtist();
            GridView1.DataSource = data;
            GridView1.DataBind();

        }
        protected void btnTombol_Load(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            if (custo != null)
            {
                if (custo.CustomerRole == "Admin")
                {
                    btnTombol.Visible = true;
                }
            }


        }

        protected void btnTombol_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertArtistPage.aspx");
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            String Link = "UpdateArtistPage.aspx?id=" + row.Cells[1].Text;
            Response.Redirect(Link);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            String name = row.Cells[1].Text;

            th.DeleteArtist(name);
            Response.Redirect("HomePage.aspx");

        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Imageklik")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];
                String name = row.Cells[1].Text;
                data = tr.findArtist(name);
                Response.Redirect("ArtistDetailPage.aspx?id=" + Convert.ToInt32(data.ArtistID));
            }
        }

    }
}