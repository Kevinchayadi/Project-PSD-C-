using KpopZtation.Controller;
using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateArtistPage : System.Web.UI.Page
    {
        AlbumArtistController tc = new AlbumArtistController();
        ArtistHandler th = new ArtistHandler();
        String id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool nama = false;
            bool foto = false;
            String link = "";

            nama = tc.checkeddata(ArtisName.Text);
            WarningNameArtis.Text = tc.CheckArtisname(nama);


            WarningPhoto.Text = tc.checkimg(fileUpload);
            if (WarningPhoto.Text.Equals(""))
            {
                string fileName = Path.GetFileName(fileUpload.FileName);
                string folderPath = Server.MapPath("~/KpopZtation/Images/" + fileName);
                link = "~/KpopZtation/Images/" + fileName;
                fileUpload.SaveAs(folderPath);
                foto = true;
            }

            if (nama == true && foto == true)
            {

                notif.Text = th.UpdateArtist(ArtisName.Text, link, id);
            }
        }
    }
}