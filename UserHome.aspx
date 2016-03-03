<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="WebApplication3.UserHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
     
    <div style="width:450px; margin: 0 auto; background-color:#fff; height:75px; margin-bottom:20px">
        <div style="margin-left:50px; padding-top:20px;">
            <asp:Label ID="Welcome_Label" runat="server" Font-Size="XX-Large" ForeColor="#FF3300" Text="Welcome, " ></asp:Label>
            <asp:Label ID="Name_Label" runat="server" Font-Size="X-Large" Text="User"></asp:Label>
        </div>
        
    </div>
    <div style="width:450px; margin: 0 auto; background-color:#fff; height:350px">
        <asp:Button ID="View_Props_Butt" runat="server" Height="150px" Text="Manage Existing Properties" Width="200px" style="font-weight: 700; float:left;  margin-left:20px; margin-right:10px; margin-top:20px;" />
        <asp:Button ID="Logout_Button" runat="server" Height="150px" Text="Logout" Width="200px"  style="font-weight: 700; float:left; margin-top:20px;" OnClick="Logout_Button_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="AddNew_Butt" runat="server" Height="150px" Text="Add New Property" Width="410px" style="font-weight: 700; float:left; margin-top:10px; margin-left:20px;" OnClick="AddNew_Butt_Click"  />
    </div>
</asp:Content>
