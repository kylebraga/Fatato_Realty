using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Context_Files;

namespace WebApplication3
{
    public partial class PropertyDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNew_Features.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            setDisplayInfo();
            Response.Redirect("UserHome.aspx");
        }

        private void setDisplayInfo()
        {
            setIconList();
            setCoverImage();
            setOtherPhotos();
        }

        private void setIconList()
        { 
            if (PropertyIcons_CL.Items.Count > 0 || PropertyIcons_CL.Items.Count <= 4)
            {
                List<string> selectedValues = PropertyIcons_CL.Items.Cast<ListItem>()
                    .Where(li => li.Selected)
                    .Select(li => li.Value)
                    .ToList();

                for (int i = 0; i < selectedValues.Count; i++)
                {
                    New_Property_Listing.displayIconString += selectedValues[i] + ",";
                }
            }
        }

        private void setCoverImage()
        {

        }

        private void setOtherPhotos()
        {

        }
     
    }
}