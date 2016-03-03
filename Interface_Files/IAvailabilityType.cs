using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Class_Files
{
    public interface IAvailabilityType
    {
        int AvailabilityTypeId { get; set; }
        string AvailabilityTypeDesc { get; set; }
    }
}
