using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class AvailabilityType
    {
        private int _availabilityTypeId;
        private string _availabilityTypeDesc;

        public AvailabilityType(int availabilityTypeId,string availabilityTypeDesc)
        {
             _availabilityTypeId = availabilityTypeId;
             _availabilityTypeDesc = availabilityTypeDesc;
        }

        
        public int AvailabilityTypeId
        {
            get
            {
                return _availabilityTypeId;
            }
            set
            {
                _availabilityTypeId = value;
            }
        }
        public String AvailabilityTypeDesc
        {
            get
            {
                return _availabilityTypeDesc;
            }
            set
            {
                _availabilityTypeDesc = value;
            }
        }
    }
}