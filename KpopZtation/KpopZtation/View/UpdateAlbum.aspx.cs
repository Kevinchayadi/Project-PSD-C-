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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        AlbumArtistController tc = new AlbumArtistController();
        AlbumHandler th = new AlbumHandler();
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool foto = false;
            String link = " ";

            bool nama = tc.checkeddata(AlbumName.Text);
            bool desc = tc.checkeddata(AlbumDesc.Text);
            bool price = tc.checkeddata(albumPrice.Text.ToString());
            bool stock = tc.checkeddata(albumStock.Text.ToString());

            Warningname.Text = tc.Checkalbumname(nama);
            WarningDecs.Text = tc.CheckAlbumdesc(desc, AlbumDesc.Text.Length);
            WarningPrice.Text = tc.CheckAlbumPrice(price, int.Parse(albumPrice.Text));
            WarningStock.Text = tc.CheckAlbumstock(stock, int.Parse(albumStock.Text));


            WarningPhoto.Text = tc.checkimg(fileUpload);
            if (WarningPhoto.Text.Equals(""))
            {
                string fileName = Path.GetFileName(fileUpload.FileName);
                string folderPath = Server.MapPath("~/KpopZtation/Images/" + fileName);
                link = "~/KpopZtation/Images/" + fileName;
                fileUpload.SaveAs(folderPath);
                foto = true;
            }

            if (nama == true && desc == true && price == true && stock == true && foto == true)
            {
                notif.Text = th.UpdateAlbum(id, AlbumName.Text, int.Parse(ID), AlbumDesc.Text, int.Parse(albumPrice.Text), int.Parse(albumStock.Text), link);
            }
        }
    }
}