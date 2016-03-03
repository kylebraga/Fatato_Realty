using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Class_Files
{
    public interface ILaundryType
    {
        int LaundryTypeId { get; set; }
        string LaundryTypeDesc { get; set; }
    }
}
