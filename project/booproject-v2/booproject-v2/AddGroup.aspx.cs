using booproject_v2.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace booproject_v2
{
    public partial class AddGroup : System.Web.UI.Page
    {
        string name = "";
        string members = "";
        DataClassesDataContext db = new DataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var confirmview = from Group in db.Groups
                              select new
                              {
                                  groupname = Group.groupid,
                                  members = Group.members,
                              };
            GridViewGroup.DataSource = confirmview;
            GridViewGroup.DataBind();
        }
        protected void ReturnToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            db.Groups.InsertOnSubmit(new Group() { groupid = groupnameinput.Text, members = int.Parse(membersinput.Text) });
            db.SubmitChanges();
            TextBox confirm = new TextBox();
            confirm.Text = "Pridano!";
            confirmgroup.Controls.Add(confirm);
            var confirmview = from Group in db.Groups
                              select new
                              {
                                  groupname = Group.groupid,
                                  members = Group.members,
                              };
            GridViewGroup.DataSource = confirmview;
            GridViewGroup.DataBind();


        }
    }
}