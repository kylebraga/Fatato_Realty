using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Context_Files;

namespace WebApplication3
{
    public partial class AddNew_Features : System.Web.UI.Page
    {
        bool isBasicUtilitiesCoverage;

        protected void Page_Load(object sender, EventArgs e)
        {
            setUtilityVisibility(false, false);
            isBasicUtilitiesCoverage = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewProperrt_BaiscInfo.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            setPropertyDetails();
            Response.Redirect("PropertyDisplay.aspx");
        }

        private void setPropertyDetails()
        {
            setFeatures();
            setAvailability();
            setPets();
            setUtilities();
        }

        private void setFeatures()
        {
            New_Property_Listing.smokingType = Smoking_RL.SelectedValue;
            New_Property_Listing.parkingType = Parking_RL.SelectedValue;
            New_Property_Listing.furnishType = Furnish_RL.SelectedValue;
            New_Property_Listing.laundryType = Laundry_RL.SelectedValue;
            New_Property_Listing.publicTransType = PubTrans_RL.SelectedValue;
            New_Property_Listing.numParkSpots = NumPark_Textbox.Text;
        }

        private void setAvailability()
        {
            string availChoice = AvailType_RL.SelectedValue;

            if((availChoice != "Not Available") || (availChoice != "For Sale"))
            {
                New_Property_Listing.leaseDuration = LeaseDuration_Textbox.Text;
            }

            if (availChoice == "Lease on Date")
            {
                New_Property_Listing.availDate = Date_Textbox.Text;
            }

            New_Property_Listing.availabilityType = AvailType_RL.SelectedValue;
        }

        private void setPets()
        {
            string[] petArray = new string[10];

            List<string> selectedValues = Pet_CL.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .Select(li => li.Value)
                .ToList();

            for (int i = 0; i < selectedValues.Count; i++)
            {
                New_Property_Listing.allowedPetString += selectedValues[i] + ",";
            }
            
        }

        private void setUtilities()
        {
            string includedInRentString = "Included in Rent";
            string coveredByTenantString = "Covered by Tenant";
            string allUtilsIncludedString = "All Utilities Included";
            string noUtilsIndluededString = "No Utilities Included";

            if (isBasicUtilitiesCoverage)
            {
                string basicChoice = BasicCoverage_RadioList.SelectedValue;

                if (basicChoice == noUtilsIndluededString)
                {
                    setAllUtilitiesSameValue(noUtilsIndluededString);
                }
                else
                {
                    setCustomUtilities();
                }
            }
            else
            {
                setCustomUtilities();
            }

            New_Property_Listing.averageUtilCost = AvgUtilcost_Textbox.Text;
    
        }

        private void setAllUtilitiesSameValue(string coverageType)
        {
            New_Property_Listing.heatUtil = coverageType;
            New_Property_Listing.waterUtil = coverageType;
            New_Property_Listing.electricUtil = coverageType;
            New_Property_Listing.garbageUtil = coverageType;
            New_Property_Listing.sewerUtil = coverageType;
            New_Property_Listing.lawnUtil = coverageType;
            New_Property_Listing.snowUtil = coverageType;
            New_Property_Listing.cableUtil = coverageType;   
        }

        private void setCustomUtilities()
        {
            New_Property_Listing.heatUtil = Heat_RBL.SelectedValue;
            New_Property_Listing.waterUtil = Water_RBL.SelectedValue;
            New_Property_Listing.electricUtil = Electric_RBL.SelectedValue;
            New_Property_Listing.garbageUtil = Garbage_RBL.SelectedValue;
            New_Property_Listing.sewerUtil = Sewer_RBL.SelectedValue;
            New_Property_Listing.lawnUtil = Lawn_RBL.SelectedValue;
            New_Property_Listing.snowUtil = Snow_RBL.SelectedValue;
            New_Property_Listing.cableUtil = Cable_RBL.SelectedValue;
        }

        protected void Basic_Coverage_Butt_Click(object sender, EventArgs e)
        {
            isBasicUtilitiesCoverage = true;
            setUtilityVisibility(true, false);
        }

        protected void Custom_Coverage_Butt_Click(object sender, EventArgs e)
        {
            isBasicUtilitiesCoverage = false;
            setUtilityVisibility(false, true);
        }

        private void setUtilityVisibility(bool basicCoverageUtils, bool customCoverageUtils)
        {
            BasicCoverage_RadioList.Visible = basicCoverageUtils;
            BasicCoverage_Label.Visible = basicCoverageUtils;
            CustomCoverage_Label.Visible = customCoverageUtils;
            Heat_Label.Visible = customCoverageUtils;
            Heat_RBL.Visible = customCoverageUtils;
            Water_Label.Visible = customCoverageUtils;
            Water_RBL.Visible = customCoverageUtils;
            Electric_Label.Visible = customCoverageUtils;
            Electric_RBL.Visible = customCoverageUtils;
            Garbage_Label.Visible = customCoverageUtils;
            Garbage_RBL.Visible = customCoverageUtils;
            Sewer_Label.Visible = customCoverageUtils;
            Sewer_RBL.Visible = customCoverageUtils;
            Lawn_Label.Visible = customCoverageUtils;
            Lawn_RBL.Visible = customCoverageUtils;
            Snow_Label.Visible = customCoverageUtils;
            Snow_RBL.Visible = customCoverageUtils;
            Cable_Label.Visible = customCoverageUtils;
            Cable_RBL.Visible = customCoverageUtils;
        }
        
    }
}