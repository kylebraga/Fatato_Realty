<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    <div id="Title_Wrap" style="font-weight: 700;  background-color: #fff; margin-bottom:20px; ">
        <h2 style=" padding:10px; text-align:center">Property Manager Application</h2>
    </div>
    <div id="Login_Wrap" style="font-weight: 700; padding:5%;  background-color: #fff; float:left">
        <asp:Label ID="Login_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Login To Access Manager"></asp:Label>
        <br />
        <br />   
        <asp:Label ID="Email_Label" runat="server" Font-Size="Medium" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="EmailLogIn_Input_TextBox" runat="server" Font-Italic="False" Width="359px" TextMode="Email" Height ="20px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Password_Label" runat="server" Font-Size="Medium" Text="Password:"></asp:Label>
        <br />
        <asp:TextBox ID="Password_Input_TextBox" runat="server" Font-Italic="True" Width="359px" TextMode="Password" Height="20px">enter password</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="LoginButton" runat="server" Height="30px" Text="Login" Width="110px" OnClick="Login_Attempt_OnClick" />
    </div>
    <div id="Email_Admin_Div" style="font-weight: 700; padding: 5%;  background-color: #fff; float:right; box-shadow:inherit;">
        <asp:Label ID="Request_Credentials_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="Request Credentials"></asp:Label>
        <br />
        <br />   
        <asp:Label ID="EmailRequest_Label" runat="server" Font-Size="Medium" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="EmailRequest_Textbox" runat="server" Font-Italic="False" Width="359px" TextMode="Email" Height="20px" OnTextChanged="RequestTextBoxOnTextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="RequestNotes_Label" runat="server" Font-Size="Medium" Text="Notes:"></asp:Label>
        <br />
        <asp:TextBox ID="Credential_Request_Notes_TextBox" runat="server" Font-Italic="False" Width="359px" Height="125px" TextMode="MultiLine" OnTextChanged="RequestNotesOnTextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Send_Request_Button" runat="server" Height="30px" Text="Send Request" Width="110px" OnClick="Send_Credential_Request_OnClick" />
        <br />
        <asp:Label ID="Request_Success_Label" runat="server" Text="Request Sent" ForeColor="Red" Font-Size="Large"></asp:Label>
    </div>
    

   
</asp:Content>
