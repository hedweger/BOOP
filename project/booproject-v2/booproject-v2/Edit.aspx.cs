using booproject_v2.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace booproject_v2
{
    public partial class Edit : System.Web.UI.Page
    {
        DataClassesDataContext db = new DataClassesDataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void ReturnToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void confirmtype_Click(object sender, EventArgs e)
        {
            if (DropDownList.SelectedValue == "1")
            {
                var confirmview = from Group in db.Groups
                                  where Group.groupid == nameinput.Text
                                  select new
                                  {
                                      groupname = Group.groupid,
                                      members = Group.members,
                                  };
                if (confirmview.Count() <= 0)
                {
                    TextBox error = new TextBox();
                    error.Text = "Neexistuje";
                    input1.Controls.Add(error);
                }
                else
                {
                    foreach (var obj in confirmview)
                    {
                        input1.Text = obj.groupname;
                        input2.Text = obj.members.ToString();
                    }
                    input1.Visible = true;
                    input1.ReadOnly = true;
                    input2.Visible = true;
                    
                }
            }
            else if (DropDownList.SelectedValue == "2")
            {
                var confirmview = from Album in db.Albums
                                  where Album.albumid == nameinput.Text
                                  select new
                                  {
                                      albumname = Album.albumid,
                                      genre = Album.genre,
                                      tracksamount = Album.tracksamount,
                                      release = Album.release,
                                  };
                if (confirmview.Count() <= 0)
                {
                    TextBox error = new TextBox();
                    error.Text = "Neexistuje";
                    input1.Controls.Add(error);
                }
                else
                {
                    foreach (var obj in confirmview)
                    {
                        input1.Text = obj.albumname;
                        input2.Text = obj.genre.ToString();
                        input4.Text = obj.tracksamount.ToString();
                        input3.Text = obj.release.ToString();
                    }
                    input1.Visible = true;
                    input1.ReadOnly = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;

                }
            }
        }

        protected void confirmedit_Click(object sender, EventArgs e)
        {
            if (DropDownList.SelectedValue == "1")
            {
                var editgroup = db.Groups.Single(x => x.groupid == nameinput.Text);
                editgroup.members = int.Parse(input2.Text);
                db.SubmitChanges();
            }
            else if (DropDownList.SelectedValue == "2")
            {
                var editalbum = db.Albums.Single(x => x.albumid == nameinput.Text);
                editalbum.genre = input2.Text;
                editalbum.release = int.Parse(input3.Text);
                editalbum.tracksamount = int.Parse(input4.Text);
                db.SubmitChanges();
            }
        }
    }
}