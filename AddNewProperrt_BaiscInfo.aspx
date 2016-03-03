<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewProperrt_BaiscInfo.aspx.cs" Inherits="WebApplication3.AddNewProperrt_BaiscInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server"  >
    <asp:Label ID="BasicInfoTitle_Label0" runat="server" Font-Size="XX-Large" ForeColor="Red" Text="&nbsp;&nbsp;&nbsp;Basic Information" Width ="100%" BackColor="#ffffff" ></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Bigdiv" style=" float:left; background-color:#fff; padding:50px;  margin-top:10px">
        
        <div id ="AddressDic" style=" float:left; background-color:#fff; margin-right:75px; margin-top:10px;"  >
            <asp:Label ID="PropertyAddress_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Property Address"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Street_Label" runat="server" Font-Size="Medium" Text="Street Name:"></asp:Label>
            &nbsp;&nbsp; <asp:TextBox ID="Street_TextBox" runat="server" Font-Size="Medium" Width="298px"></asp:TextBox>
            &nbsp;
            <br />
            <br />
            <asp:Label ID="StreetNumber_Label" runat="server" Font-Size="Medium" Text="Street Number:"></asp:Label>
            &nbsp;&nbsp; <asp:TextBox ID="Number_TextBox" runat="server" CausesValidation="True" Font-Size="Medium" Width="64px" TextMode="Number"></asp:TextBox>
            &nbsp;&nbsp; <asp:Label ID="Apartment_Number_Label" runat="server" Font-Size="Medium" Text="Apartment Number:"></asp:Label>
            &nbsp;&nbsp; <asp:TextBox ID="ApartmentNumber_TextBox" runat="server" CausesValidation="True" Font-Size="Medium" Width="47px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="City_Label" runat="server" Font-Size="Medium" Text="City:"></asp:Label>
            &nbsp;&nbsp; <asp:TextBox ID="City_TextBox" runat="server" Font-Size="Medium" Width="96px"></asp:TextBox>
            &nbsp;
            &nbsp;<asp:Label ID="State_Label" runat="server" Font-Size="Medium" Text="State:"></asp:Label>
            &nbsp;
            &nbsp;<asp:TextBox ID="State_TextBox" runat="server" Font-Size="Medium" Width="96px"></asp:TextBox>
            &nbsp;&nbsp;<br />
            <br />
            <asp:Label ID="ZipCode_Label" runat="server" Font-Size="Medium" Text="Zip Code:"></asp:Label>
            &nbsp;&nbsp; <asp:TextBox ID="ZipCode_TextBox" runat="server" Font-Size="Medium" Width="96px" TextMode="Number"></asp:TextBox>
        </div>

        <div id ="Div3" style=" float:left; background-color:#fff;  margin-top:10px;" >
            <asp:Label ID="ProptertyType_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Property Type"></asp:Label>
            <br />
            <br />
            <asp:Label ID="CatLabel" runat="server" Font-Size="Medium" Text="Select Category:"></asp:Label>
&nbsp;
            <asp:Button ID="Commercial_Butt" runat="server" OnClick="Commercial_Butt_Click" Text="Commercial" />
&nbsp;
            <asp:Button ID="Residential_Butt" runat="server" OnClick="Residential_Butt_Click" Text="Residential" />
            <br />
            <br />
            <asp:Label ID="CommercialPropCat_Label" runat="server" Font-Size="Medium" Text="Comercial Type:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ResidentialPropCat_Label" runat="server" Font-Size="Medium" Text="Residential Type:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;<br />
            <asp:ListBox ID="CommercialType_LBox" runat="server" Width="120px" DataSourceID="ResidentialPropType_DS" DataTextField="residentialPropertyTypeName" DataValueField="residentialPropertyTypeName" Height="110px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ResProp_Lbox" runat="server" Width="120px" DataSourceID="ResidentialPropType_DS" DataTextField="residentialPropertyTypeName" DataValueField="residentialPropertyTypeName" Height="110px"></asp:ListBox>
            <asp:SqlDataSource ID="ResidentialPropType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [residentialPropertyTypeName] FROM [ResidentialPropertyType]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="CommercialPropType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [commercialPropertyTypeName] FROM [CommercialPropertyType]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div id ="Div5" style=" float:left; background-color:#fff;  margin-top:50px; margin-right:50px; width: 335px;" >
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Property Specs"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Bedrooms:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="BedNum_Textbox" runat="server" Font-Size="Medium" Width="50px" Height="16px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Bathrooms:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="BathNum_Textbox" runat="server" Font-Size="Medium" Width="50px" Height="16px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="Square Feet:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SquareFeet_Textbox" runat="server" Font-Size="Medium" Width="208px" Height="16px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;

            <br />
            <br />
            <br />
            <br />
        </div>

        <div id ="Div6" style=" float:left; background-color:#fff;  margin-top:70px; margin-right:10px; width: 396px;" >
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="Rent Information"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="Rent (per month):"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="Rent_Textbox" runat="server" Font-Size="Medium" Width="208px" Height="16px"></asp:TextBox>
            &nbsp;
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Font-Size="Medium" Text="Security Deposit:"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="SecurityDeposit_Textbox" runat="server" Font-Size="Medium" Width="208px" Height="16px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;

            <br />
        </div>

        <div id ="Div2" style=" float:left; background-color:#fff;  margin-top:10px; margin-right:10px; width:100%" >
            <asp:Label ID="PropertyDescription_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Property Description"></asp:Label>
            <br />
            <br />
            <asp:Label ID="PropertyDescriptionHint_Label" runat="server" Font-Size="Medium" Text="Enter description to be shown on 'Property Details' page:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="PropertyDescription_TextBox" runat="server" Font-Size="Medium" Width="90%" Height="212px" TextMode="MultiLine"></asp:TextBox>
        </div>
  
        
  
        <div id ="Div4" style=" float:left; background-color:#fff;  margin-top:50px; margin-right:10px; width:100%" >
            <asp:Button ID="Button2" runat="server" Text="Back" Width="80px" OnClick="Button2_Click" />

            &nbsp;&nbsp;

            <asp:Button ID="Button1" runat="server" Text="Next" Width="80px" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>
