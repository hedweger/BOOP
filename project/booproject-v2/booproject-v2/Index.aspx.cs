using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using booproject_v2.App_Data;
using CsvHelper;
using CsvHelper.Configuration;
using booproject_v2.Model;

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

        protected void WriteCSV_Click(object sender, EventArgs e)
        {
            var search = from AlbumGroup in db.AlbumGroups
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
            using (var writer = new StreamWriter("/Users/hadwoslol/Documents/code/hadwiger-oop/project/booproject-v2/booproject-v2/output/writetest.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(search);
            }
        }

        protected void ReadCSV_Click(object sender, EventArgs e)
        {
            var filepath = "/Users/hadwoslol/Documents/code/hadwiger-oop/project/booproject-v2/booproject-v2/output/readtest.csv";
            IEnumerable<AlbumGroupHelper> records = Enumerable.Empty<AlbumGroupHelper>();
            string groupid, albumid, genre;
            int members, release, tracksamount;
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<AlbumGroupHelper>();
                foreach (var obj in records)
                {
                    groupid = obj.groupid;
                    albumid = obj.albumid;
                    genre = obj.genre;
                    members = int.Parse(obj.members);
                    tracksamount = int.Parse(obj.tracksamount);
                    release = int.Parse(obj.release);

                    if (!db.Groups.Any(u => u.groupid == groupid))
                    {
                        db.Groups.InsertOnSubmit(new Group() { groupid = groupid, members = members });
                        db.SubmitChanges();
                    }
                    if (!db.Albums.Any(u => u.albumid == albumid))
                    {
                        db.Albums.InsertOnSubmit(new Album() { albumid = albumid, genre = genre, release = release, tracksamount = tracksamount });
                        db.SubmitChanges();
                    }
                    if (!db.AlbumGroups.Any(u => u.albumid == albumid))
                    {
                        db.AlbumGroups.InsertOnSubmit(new AlbumGroup() { albumid = albumid, groupid = groupid });
                        db.SubmitChanges();
                    }
                }
            }  
        }
    }
}