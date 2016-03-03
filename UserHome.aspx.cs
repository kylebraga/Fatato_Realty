using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Class_Files;
using System;
using System.Collections;

namespace WebApplication3
{
    public partial class UserHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUser tempUser = GlobalContext.CurrentUser;

            if (tempUser == null)
            {
                tempUser = new User();
                GlobalContext.CurrentUser = tempUser;
            }
           
            Name_Label.Text = GlobalContext.CurrentUser.firstName.ToString();
        }

        protected void Logout_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void AddNew_Butt_Click(object sender, System.EventArgs e)
        {
            DomainGenerator myDomainGenerator = new DomainGenerator();
            myDomainGenerator.DomainManager();
            Response.Redirect("AddNewProperrt_BaiscInfo.aspx");
        }

    }
}