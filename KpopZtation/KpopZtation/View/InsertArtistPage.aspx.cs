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
    public partial class InsertArtistPage : System.Web.UI.Page
    {
        AlbumArtistController tc = new AlbumArtistController();
        ArtistHandler th = new ArtistHandler();


        protected void Page_PreInit(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            bool foto = false;
            String link = " ";

            bool nama = tc.checkeddata(ArtisName.Text);


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
                notif.Text = th.insertArtist(ArtisName.Text, link);
                Response.Redirect("HomePage.aspx");
            }


        }
    }
}