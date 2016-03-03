using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Interface_Files;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
namespace WebApplication3.Utility_Files
{
    public class CredentialRequestService : ICredentialRequestService
    {
        private string _requestedEmail;
        private string _requestedNotes;
        private string _appEmailSender = "fatatopropertymanagementapp@gmail.com";
        private string _appEmailPassword = "FatatoRealtyBrooklyn2016";
        private string _adminEmail_1 = "kyle.braga@mymail.champlain.edu";
        private string _adminEmail_2 = "kbraga111@yahoo.com";
        private string _adminEmail_3 = "kyletheking3@gmail.com";
        private bool _isSuccessful = false;

        public CredentialRequestService(string inputEmail, string inputNotes)
        {
            _requestedEmail = inputEmail;
            _requestedNotes = inputNotes;
        }

        public bool sendCredntialRequestEmail() 
        {
            bool tempSuccess = true;

            MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new MailAddress(ApplicationEmailName);
            message.To.Add(_adminEmail_3);
            message.Subject = "PROPERTY MANAGEMENT PORTAL: NEW CREDENTIAL REQUEST";
            message.Body = "Request Time: " + DateTime.Now + "\n\n"
                + "Requested Email: " + RequestedEmail + "\n"
                + "Requested Notes: \n" + RequestedNotes;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(ApplicationEmailName, ApplicationEmailPassword);
                smtpClient.Send(message.From.ToString(), message.To.ToString(),
                                message.Subject, message.Body);
            }
            

            return tempSuccess; 
        }

        /////////////////////////////////////GET/SET FUNCTIONS///////////////////////////////////////////

        public string RequestedEmail
        {
            get
            {
                return _requestedEmail;
            }
            set
            {
                _requestedEmail = value;
            }
        }
        public string RequestedNotes
        {
            get
            {
                return _requestedNotes;
            }
            set
            {
                _requestedNotes = value;
            }
        }
        public string AdminEmail_1
        {
            get
            {
                return _adminEmail_1;
            }
            set
            {
                _adminEmail_1 = value;
            }
        }
        public string AdminEmail_2
        {
            get
            {
                return _adminEmail_2;
            }
            set
            {
                _adminEmail_2 = value;
            }
        }
        public string AdminEmail_3
        {
            get
            {
                return _adminEmail_3;
            }
            set
            {
                _adminEmail_3 = value;
            }
        }
        public bool IsSuccessful
        {
            get
            {
                return _isSuccessful;
            }
            set
            {
                _isSuccessful = value;
            }
        }
        public string ApplicationEmailName
        {
            get
            {
                return _appEmailSender;
            }
            set
            {
                _appEmailSender = value;
            }
        }
        public string ApplicationEmailPassword
        {
            get
            {
                return _appEmailPassword;
            }
            set
            {
                _appEmailPassword = value;
            }
        }




    }
}