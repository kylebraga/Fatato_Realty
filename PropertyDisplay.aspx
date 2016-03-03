<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PropertyDisplay.aspx.cs" Inherits="WebApplication3.PropertyDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server" >
    <asp:Label ID="BasicInfoTitle_Label" runat="server" Font-Size="XX-Large" Width ="100%" ForeColor="Red" Text="&nbsp;&nbsp;&nbsp;Property Display" BackColor="White"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

<div id="Bigdiv" style=" float:left; background-color:#fff; padding:50px;  margin-top:10px; width:100%" >
       
        <div id ="AddressDic" style=" float:left; background-color:#fff; margin-right:75px; margin-top:10px; width:45%;"  >
            <asp:Label ID="PropertyAddress_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Property Images"></asp:Label>
            <br />
            <br />
            <div id ="Div2" style=" float:left; background-color:#fff;  margin-top:10px; width:45%;" >
                <asp:Label ID="Street_Label" runat="server" Font-Size="Medium" Text="Cover Image:"></asp:Label>
                <br />
                <br />
                <asp:FileUpload ID="Cover_Upload" runat="server" />
                &nbsp;<br />
                <br />
                <br />
            </div>

            <div id ="Div1" style=" float:left; background-color:#fff;  margin-top:10px; width:45%;" >
                <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="Other photos:"></asp:Label>
                <br />
                <br />
                <asp:FileUpload ID="OtherPhotos_Upload" runat="server" AllowMultiple="True" />
                <br />
            </div>
        </div>

        

        <div id ="Div14" style=" float:left; background-color:#fff;  margin-top:10px; width:45%" >
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="Property Icons"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Select Feature Icons for Card Display (up to 4 selections):"></asp:Label>
            <br />
            <asp:CheckBoxList ID="PropertyIcons_CL" runat="server" DataSourceID="IconType_DS" DataTextField="cardIconTitle" DataValueField="cardIconTitle">
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="IconType_DS" runat="server" ConnectionString="<%$ ConnectionStrings:Fato_Realty_DBConnectionString %>" SelectCommand="SELECT [cardIconTitle] FROM [CardIconType]"></asp:SqlDataSource>
            <br />
        </div>
        <div id ="Div4" style=" float:left; background-color:#fff;  margin-top:50px; margin-right:10px; width:100%" >
            <asp:Button ID="Button2" runat="server" Text="Back" Width="100px" OnClick="Button2_Click"  />

            &nbsp;&nbsp;

            <asp:Button ID="Button1" runat="server" Text="Preview" Width="100px"  />
            &nbsp;&nbsp;

            <asp:Button ID="Button3" runat="server" Text="Add Property" Width="100px" OnClick="Button3_Click"/>
       
        </div>
    </div>
</asp:Content>
