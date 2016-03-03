<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNew_Features.aspx.cs" Inherits="WebApplication3.AddNew_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:Label ID="BasicInfoTitle_Label" runat="server" Font-Size="XX-Large" ForeColor="Red" Text="&nbsp;&nbsp;&nbsp;Property Details" Width ="100%" BackColor="#ffffff"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Bigdiv" style=" float:left; background-color:#fff; padding:50px;  margin-top:10px; width:100%">
      
        <div id ="AddressDic" style=" float:left; background-color:#fff; margin-right:75px; margin-top:10px; width: 100%;"  > 
            <asp:Label ID="PropertyAddress_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Features"></asp:Label>
            <br />
            <div id ="Div7" style=" float:left; background-color:#fff; margin-top:10px;  width:18%" >
                <asp:Label ID="Street_Label" runat="server" Font-Size="Medium" Text="Parking:"></asp:Label>
                <asp:RadioButtonList ID="Parking_RL" runat="server" Width="102px" DataSourceID="ParkingType_DS" DataTextField="parkingTypeName" DataValueField="parkingTypeName">
                    <asp:ListItem>Garage</asp:ListItem>
                    <asp:ListItem>On-Street</asp:ListItem>
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                <asp:SqlDataSource ID="ParkingType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [parkingTypeName] FROM [ParkingType]"></asp:SqlDataSource>
            </div>

            <div id ="Div8" style=" float:left; background-color:#fff; margin-top:10px;  width:18%" >
                <asp:Label ID="StreetNumber_Label" runat="server" Font-Size="Medium" Text="Laundry:"></asp:Label>
                <asp:RadioButtonList ID="Laundry_RL" runat="server" DataSourceID="LaundryType_DS" DataTextField="laundryTypeName" DataValueField="laundryTypeName">
                    <asp:ListItem>On-Site (coin-op)</asp:ListItem>
                    <asp:ListItem>On-Site (free)</asp:ListItem>
                    <asp:ListItem>Yes (coin-op)</asp:ListItem>
                    <asp:ListItem>Yes (free)</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                <asp:SqlDataSource ID="LaundryType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [laundryTypeName] FROM [LaundryType]"></asp:SqlDataSource>
            </div>

            <div id ="Div9" style=" float:left; background-color:#fff; margin-top:10px;  width:18%" >
                <asp:Label ID="Apartment_Number_Label" runat="server" Font-Size="Medium" Text="Furnish Type:"></asp:Label>
                <asp:RadioButtonList ID="Furnish_RL" runat="server" DataSourceID="FurnishType_DS" DataTextField="furnishedTypeName" DataValueField="furnishedTypeName">
                    <asp:ListItem>Appliances</asp:ListItem>
                    <asp:ListItem>Partial </asp:ListItem>
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                <asp:SqlDataSource ID="FurnishType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [furnishedTypeName] FROM [FurnishedType]"></asp:SqlDataSource>
            </div>

            <div id ="Div10" style=" float:left; background-color:#fff; margin-top:10px;  width:18%" >
                <asp:Label ID="City_Label" runat="server" Font-Size="Medium" Text="Smoking:"></asp:Label>     
                <asp:RadioButtonList ID="Smoking_RL" runat="server" DataSourceID="SmokingType_DS" DataTextField="smokingTypeName" DataValueField="smokingTypeName">
                    <asp:ListItem>Outside</asp:ListItem>
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                <asp:SqlDataSource ID="SmokingType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [smokingTypeName] FROM [SmokingType]"></asp:SqlDataSource>
            </div>

            <div id ="Div2" style=" float:left; background-color:#fff; margin-top:10px;  width:18%" >
                <asp:Label ID="Label5" runat="server" Font-Size="Medium" Text="Near Public Transport:"></asp:Label>
                <asp:RadioButtonList ID="PubTrans_RL" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div id ="Div25" style=" float:left; background-color:#fff; margin-top:40px;  width:100%" >
                    <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="Number of Parking Spots:"></asp:Label>
                    
                &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="NumPark_Textbox" runat="server" Width="99px" TextMode="Number"></asp:TextBox>
           </div>
        </div>
            <br /><br />


        <div id ="Div3" style=" float:left; background-color:#fff;  margin-top:50px; width:50%; margin-right:10%" >
            <asp:Label ID="ProptertyType_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Availability"></asp:Label>
            <br />
            <div id ="Div11" style=" float:left; background-color:#fff; margin-top:10px;  width:45%" >
                <asp:Label ID="PropertyTypeHigh_Label" runat="server" Font-Size="Medium" Text="By Type:"></asp:Label>
                <asp:RadioButtonList ID="AvailType_RL" runat="server" DataSourceID="AvailType_DS" DataTextField="availName" DataValueField="availName">
                    <asp:ListItem>For Sale</asp:ListItem>
                    <asp:ListItem>Available Now</asp:ListItem>
                    <asp:ListItem>Available On Date</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                <asp:SqlDataSource ID="AvailType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [availName] FROM [AvailabilityType]"></asp:SqlDataSource>
            </div>
            <div id ="Div12" style=" float:left; background-color:#fff; margin-top:10px;  width:50%" >
                <asp:Label ID="SelectType_Label" runat="server" Font-Size="Medium" Text="By Date"></asp:Label> 
                <asp:Label ID="AvailByDateDeatails_Label" runat="server" Font-Size="Small" Text="(if 'Lease on Date' is selected):"></asp:Label>
                <br />
                <asp:TextBox ID="Date_Textbox" runat="server" Width="254px" TextMode="Date"></asp:TextBox>
            
                <asp:Label ID="SelectType_Label0" runat="server" Font-Size="Medium" Text="Lease Duration (months):"></asp:Label> 
                <asp:TextBox ID="LeaseDuration_Textbox" runat="server" Width="254px" TextMode="Number"></asp:TextBox>
            </div>
        </div>
        
        <div id ="Div5" style=" float:left; background-color:#fff;  margin-top:50px; width: 35%;" >
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Pet Information:"></asp:Label>
            <br />
            <div id ="Div23" style=" float:left; background-color:#fff; margin-top:10px;  width:100%" >
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Select all that apply:"></asp:Label>
                <br />
                <asp:CheckBoxList ID="Pet_CL" runat="server" DataSourceID="PetType_DS" DataTextField="petTypeName" DataValueField="petTypeName">
                </asp:CheckBoxList>
                <asp:SqlDataSource ID="PetType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [petTypeName] FROM [PetType]"></asp:SqlDataSource>
                <br />
            </div>
        </div>

        <div id ="Div6" style=" float:left; background-color:#fff; margin-right:75px; margin-top:25px; width: 100%;"  > 
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="Utilities"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Basic_Coverage_Butt" runat="server" Text="Basic Coverage" Width="125px" OnClick="Basic_Coverage_Butt_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Custom_Coverage_Butt" runat="server" Text="Custom Coverage" Width="125px" OnClick="Custom_Coverage_Butt_Click" />
            <br />
            
            <div id ="Div1" style=" float:left; background-color:#fff; margin-right:75px; margin-top:10px; width: 100%;"  > 
                <asp:Label ID="BasicCoverage_Label" runat="server" Font-Size="Medium" Text="Select Basic Coverage:"></asp:Label>
                <br />
                <asp:RadioButtonList ID="BasicCoverage_RadioList" runat="server">
                    <asp:ListItem>All Utilities Included</asp:ListItem>
                    <asp:ListItem>No Utilities Included</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div id ="Div20" style=" float:left; background-color:#fff; margin-right:75px; margin-top:10px; width: 100%;" > 
                <div id ="Div13" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <asp:Label ID="CustomCoverage_Label" runat="server" Font-Size="Medium" Text="Select Custom Coverage:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Heat_Label" runat="server" Font-Size="Medium" Text="Heat:"></asp:Label>
                    <asp:RadioButtonList ID="Heat_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <div id ="Div14" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <br />
                    <br />
                    <asp:Label ID="Water_Label" runat="server" Font-Size="Medium" Text="Water:"></asp:Label>
                    <asp:RadioButtonList ID="Water_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <div id ="Div15" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <br />
                    <br />
                    <asp:Label ID="Electric_Label" runat="server" Font-Size="Medium" Text="Electricity:"></asp:Label>
                    <asp:RadioButtonList ID="Electric_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <div id ="Div16" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <br />
                    <br />
                    <asp:Label ID="Garbage_Label" runat="server" Font-Size="Medium" Text="Garbage:"></asp:Label>     
                    <asp:RadioButtonList ID="Garbage_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <br />
            </div>

            <div id ="Div21" style=" float:left; background-color:#fff; margin-right:75px; margin-top:10px; width: 100%;" > 
                <div id ="Div17" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <asp:Label ID="Sewer_Label" runat="server" Font-Size="Medium" Text="Sewer:"></asp:Label>
                    <asp:RadioButtonList ID="Sewer_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div id ="Div18" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <asp:Label ID="Lawn_Label" runat="server" Font-Size="Medium" Text="Lawn:"></asp:Label>
                    <asp:RadioButtonList ID="Lawn_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div id ="Div19" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <asp:Label ID="Snow_Label" runat="server" Font-Size="Medium" Text="Snow Removal:"></asp:Label>
                    <asp:RadioButtonList ID="Snow_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div id ="Div22" style=" float:left; background-color:#fff; margin-top:10px;  width:24%" >
                    <asp:Label ID="Cable_Label" runat="server" Font-Size="Medium" Text="Cable/Wifi:"></asp:Label>
                    <asp:RadioButtonList ID="Cable_RBL" runat="server">
                        <asp:ListItem>Included in Rent</asp:ListItem>
                        <asp:ListItem>Covered by Tenant</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div id ="Div24" style=" float:left; background-color:#fff; margin-top:40px;  width:100%" >
                    <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Estimated Average Monthly Utility Cost:"></asp:Label>
                    
                &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="AvgUtilcost_Textbox" runat="server" Width="193px"></asp:TextBox>
                    
                </div>
            </div>
        </div>

        <div id ="Div4" style=" float:left; background-color:#fff;  margin-top:50px; margin-right:10px; width:100%" >
            <asp:Button ID="backButt" runat="server" Text="Back" Width="80px" OnClick="Button2_Click" />

            &nbsp;&nbsp;

            <asp:Button ID="nextButt" runat="server" Text="Next" Width="80px" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>
