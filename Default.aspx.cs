using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Class_Files;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Utility_Files;
using WebApplication3.Interface_Files;
namespace WebApplication3
{
    
    
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            IUser tempUser = GlobalContext.CurrentUser;

            if (tempUser == null)
            {
                tempUser = new User();
                GlobalContext.CurrentUser = tempUser;
            }
            Request_Success_Label.Visible = false;
        }
        
        private void User_Factory(SqlDataReader reader)
        {
            while (reader.Read())
            {
                GlobalContext.CurrentUser.userId = Int32.Parse((String.Format("{0}", reader[0])));
                GlobalContext.CurrentUser.userEmail = (String.Format("{0}", reader[1]));
                GlobalContext.CurrentUser.passWord = (String.Format("{0}", reader[2]));
                GlobalContext.CurrentUser.isAdmin = (Boolean.Parse(String.Format("{0}", reader[3])));
                GlobalContext.CurrentUser.firstName = (String.Format("{0}", reader[4]));
                GlobalContext.CurrentUser.middleName = (String.Format("{0}", reader[5]));
                GlobalContext.CurrentUser.lastName = (String.Format("{0}", reader[6]));
                //MyGlobalContext.currentUser.dateCreated = (DateTime.Parse(String.Format("{0}", reader[7])));
                //MyGlobalContext.currentUser.lastLogin = (DateTime.Parse(String.Format("{0}", reader[8])));
            }

        }

        protected void Login_Attempt_OnClick(object sender, EventArgs e)
        {
            if (this.EmailLogIn_Input_TextBox.Text != null && this.EmailLogIn_Input_TextBox.Text != null)
            {
                string inputEmail = this.EmailLogIn_Input_TextBox.Text;
                string inputPass = this.Password_Input_TextBox.Text;

                Look_For_User(inputEmail,inputPass);
            }
        }

        private void Look_For_User(string inputEmail, string inputPass)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server= localhost\\SQLEXPRESS;Database= Fato_Realty_DB;Trusted_Connection=true";
                conn.Open();

                SqlCommand command = new SqlCommand((String.Format("SELECT * FROM UserInfo WHERE userEmail = '{0}' AND passWord = '{1}'", inputEmail, inputPass)), conn);

                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (!reader.HasRows.Equals(false))
                {
                    User_Factory(reader);
                    Response.Redirect("UserHome.aspx");
                }              
            }
        }

        protected void Send_Credential_Request_OnClick(object sender, EventArgs e)
        {
            if (("" != EmailRequest_Textbox.Text) && ("" != Credential_Request_Notes_TextBox.Text))
            {
                ICredentialRequestService MyCredentialService = new CredentialRequestService(EmailRequest_Textbox.Text, Credential_Request_Notes_TextBox.Text);
                MyCredentialService.sendCredntialRequestEmail();
                Credential_Request_Notes_TextBox.Text = "";
                EmailRequest_Textbox.Text = "";
                Request_Success_Label.Visible = true;
            }
            else
            {
                Credential_Request_Notes_TextBox.Text = "Please Enter Valid Email and Note To Admin Before Sending Request";
            }
            
        }

        protected void RequestTextBoxOnTextChanged(object sender, EventArgs e)
        {
            Request_Success_Label.Visible = false;
        }

        protected void RequestNotesOnTextChanged(object sender, EventArgs e)
        {
            Request_Success_Label.Visible = false;
        }
    }
}