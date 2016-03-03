using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Class_Files
{
    public interface IUser
    {
        int userId  { get; set;}
        string userEmail    { get; set;}
        string passWord{get; set;}
        bool isAdmin    {get; set;}
        string firstName    {get; set;}
        string middleName    {get; set;}
        string lastName    {get; set;}
        DateTime dateCreated    {get; set;}
        DateTime lastLogin    {get; set;}
    }
}
