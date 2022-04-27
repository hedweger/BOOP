using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using booproject_v2.App_Data;

namespace booproject_v2
{
    public partial class Index : System.Web.UI.Page
    {
        DataClassesDataContext db = new DataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var view = from AlbumGroup in db.AlbumGroups
                       join Album in db.Albums
                       on AlbumGroup.albumid equals Album.albumid
                       join Group in db.Groups
                       on AlbumGroup.groupid equals Group.groupid
                       select new
                       {
                           groupid = AlbumGroup.groupid,
                           members = Group.members,
                           albumid = AlbumGroup.albumid,
                           release = Album.release,
                           genre = Album.genre,
                           tracksamount = Album.tracksamount,
                       };
            GridViewAll.DataSource = view;
            GridViewAll.DataBind();
        }

        protected void AddAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAlbum.aspx");
        }
        protected void AddGroup_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddGroup.aspx");
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }
        protected void Search_Click(object sender, EventArgs e)
        {
            var search = from AlbumGroup in db.AlbumGroups where AlbumGroup.groupid == SearchInput.Text
                       join Album in db.Albums
                       on AlbumGroup.albumid equals Album.albumid
                       join Group in db.Groups
                       on AlbumGroup.groupid equals Group.groupid
                       select new
                       {
                           groupid = AlbumGroup.groupid,
                           members = Group.members,
                           albumid = AlbumGroup.albumid,
                           release = Album.release,
                           genre = Album.genre,
                           tracksamount = Album.tracksamount,
                       };
            GridViewSearch.DataSource = search;
            GridViewSearch.DataBind();
        }
    }
}