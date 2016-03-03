using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Interface_Files
{
    public interface ICredentialRequestService
    {
        string RequestedEmail { get; set; }
        string RequestedNotes { get; set; }
        string AdminEmail_1 { get; set; }
        string AdminEmail_2 { get; set; }
        string AdminEmail_3 { get; set; }
        bool IsSuccessful { get; set; }
        string ApplicationEmailName { get; set; }
        string ApplicationEmailPassword { get; set; }


        bool sendCredntialRequestEmail();
    }
}
