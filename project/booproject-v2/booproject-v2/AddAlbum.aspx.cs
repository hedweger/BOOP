using booproject_v2.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace booproject_v2
{
    public partial class AddAlbum : System.Web.UI.Page
    {
        DataClassesDataContext db = new DataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var confirmview = from Album in db.Albums
                              select new
                              {
                                  albumname = Album.albumid,
                                  genre = Album.genre,
                                  release = Album.release,
                                  tracksamount = Album.tracksamount,
                              };
            GridViewAlbum.DataSource = confirmview;
            GridViewAlbum.DataBind();
        }
        protected void ReturnToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            var groupcheck = from Group in db.Groups where Group.groupid == groupnameinut.Text select Group;
            if (groupcheck.Count() > 0)
            {
                db.Albums.InsertOnSubmit(new Album()
                {
                    albumid = albumnameinput.Text,
                    genre = genreinput.Text,
                    release = int.Parse(releaseinput.Text),
                    tracksamount = int.Parse(tracksinput.Text)
                });
                db.SubmitChanges();
                TextBox confirm = new TextBox();
                confirm.Text = "Pridano!";
                confirmalbum.Controls.Add(confirm);
                var confirmview = from Album in db.Albums
                                  select new
                                  {
                                      albumname = Album.albumid,
                                      genre = Album.genre,
                                      release = Album.release,
                                      tracksamount = Album.tracksamount,
                                  };
                GridViewAlbum.DataSource = confirmview;
                GridViewAlbum.DataBind();

                db.AlbumGroups.InsertOnSubmit(new AlbumGroup()
                {
                    albumid = albumnameinput.Text,
                    groupid = groupnameinut.Text,
                });
                db.SubmitChanges();
                TextBox confirmconn = new TextBox();
                confirmconn.Text = "Prirazeno ke skupine";
                confirmconnection.Controls.Add(confirmconn);
            }
            else
            {
                TextBox nogroup = new TextBox();
                nogroup.Text = "Skupina neexistuje";
                confirmconnection.Controls.Add(nogroup);
            }
        }
    }
}