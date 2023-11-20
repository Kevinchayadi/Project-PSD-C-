using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ArtistDetailPage : System.Web.UI.Page
    {
        AlbumHandler albumh = new AlbumHandler();
        ArtistHandler artisth = new ArtistHandler();
        String artisId;
        public Artist artist = new Artist();
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            ArtistAndAlbum.Columns[0].Visible = false;
            ArtistAndAlbum.Columns[1].Visible = false;
            if (custo != null)
            {
                if (custo.CustomerRole == "Admin")
                {
                    ArtistAndAlbum.Columns[0].Visible = true;
                    ArtistAndAlbum.Columns[1].Visible = true;
                    insertButton.Visible = true;
                }
            }
            artisId = Request.QueryString["id"];
            artist = artisth.findArtisById(Convert.ToInt32(artisId));
            ArtistAndAlbum.DataSource = albumh.getArtisAlbum(Convert.ToInt32(artisId));
            ArtistAndAlbum.DataBind();
        }

        private void refreshGird()
        {
            ArtistAndAlbum.DataSource = albumh.getArtisAlbum(Convert.ToInt32(artisId));
            ArtistAndAlbum.DataBind();
        }

        protected void ArtistAndAlbum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label1.Text = Convert.ToInt32(ArtistAndAlbum.Rows[e.RowIndex].Cells[2].Text).ToString();
            //albumh.deleteAlbum(Convert.ToInt32(ArtistAndAlbum.Rows[e.RowIndex].Cells[2].Text));
            //refreshGird();
        }

        protected void ArtistAndAlbum_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "updateBtn")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("AlbumDetailPage.aspx?id=" + ArtistAndAlbum.Rows[rowIndex].Cells[2].Text);
            }
        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/insertAlbumPage.aspx" + artisId);
        }
    }
}