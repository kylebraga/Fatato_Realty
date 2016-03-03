using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class ParkingType
    {
        private int _parkingTypeId;
        private string _parkingTypeDesc;

        public ParkingType(int parkingTypeId, string parkingTypeDesc)
        {
            _parkingTypeId = parkingTypeId;
            _parkingTypeDesc = parkingTypeDesc;
        }

        public int ParkingTypeId
        {
            get
            {
                return _parkingTypeId;
            }
            set
            {
                _parkingTypeId = value;
            }
        }

        public String ParkingTypeDesc
        {
            get
            {
                return _parkingTypeDesc;
            }
            set
            {
                _parkingTypeDesc = value;
            }
        }
    }
}