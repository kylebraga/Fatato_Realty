using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace WebApplication3.Class_Files
{
    public interface IParkingInformation
    {
        int ParkingInfoId { get; set; }
        int PropertyId { get; set; }
        int ParkingInformationTypeId { get; set; }
        int NumParkingSpots { get; set; }
    }
}
