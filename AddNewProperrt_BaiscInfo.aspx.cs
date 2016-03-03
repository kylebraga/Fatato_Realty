using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Context_Files;

namespace WebApplication3
{
    public partial class AddNewProperrt_BaiscInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResidentialPropCat_Label.Visible = false;
            ResProp_Lbox.Visible = false;
            CommercialType_LBox.Visible = false;
            CommercialPropCat_Label.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            setNewListingBasicInfo();
            Response.Redirect("AddNew_Features.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        private void setNewListingBasicInfo()
        {
            setAddressInfo();
            setDescriptionInfo();
            setPropertySpecsInfo();
            setPropertyTypeInfo();
            setRetInfo();    
        }

        private void setAddressInfo()
        {
            New_Property_Listing.streetName = Street_TextBox.Text;
            New_Property_Listing.streetNum = Number_TextBox.Text;
            New_Property_Listing.appartNum = ApartmentNumber_TextBox.Text;
            New_Property_Listing.city = City_TextBox.Text;
            New_Property_Listing.state = State_TextBox.Text;
            New_Property_Listing.zip = ZipCode_TextBox.Text;
        }

        private void setPropertyTypeInfo()
        {
            if (New_Property_Listing.propCat == "Commercial")
            {
                New_Property_Listing.propType = CommercialType_LBox.SelectedValue;
            }
            else if (New_Property_Listing.propCat == "Residential")
            {
                New_Property_Listing.propType = ResProp_Lbox.SelectedValue;
            }
            else
            {
                New_Property_Listing.propType = "Not Selected";
            }
        }

        private void setPropertySpecsInfo()
        {
            New_Property_Listing.bedNum = BedNum_Textbox.Text;
            New_Property_Listing.bathNum = BathNum_Textbox.Text;
            New_Property_Listing.squareFeet= SquareFeet_Textbox.Text;
        }

        private void setRetInfo()
        {
            New_Property_Listing.rent = Rent_Textbox.Text;
            New_Property_Listing.securityDeposit = SecurityDeposit_Textbox.Text;
        }

        private void setDescriptionInfo()
        {
            New_Property_Listing.description = PropertyDescription_TextBox.Text;
        }

        protected void Commercial_Butt_Click(object sender, EventArgs e)
        {
            triggerCommercialTypes();
        }

        protected void Residential_Butt_Click(object sender, EventArgs e)
        {
            triggerResidentialTypes();
        }

        private void triggerCommercialTypes()
        {
            New_Property_Listing.propCat = "Commercial";

            ResidentialPropCat_Label.Visible = false;
            ResProp_Lbox.Visible = false;
            CommercialType_LBox.Visible = true;
            CommercialPropCat_Label.Visible = true;
        }

        private void triggerResidentialTypes()
        {
            New_Property_Listing.propCat = "Residential";

            ResidentialPropCat_Label.Visible = true;
            ResProp_Lbox.Visible = true;
            CommercialType_LBox.Visible = false;
            CommercialPropCat_Label.Visible = false;
        }       
    }
}