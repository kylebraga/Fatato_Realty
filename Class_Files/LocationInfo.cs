using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class LocationInfo
    {
        public int LocationInfoId;
        public int PropertyId;
        public string StreetName;
        public int StreetNumber;
        public string CityName;
        public string StateName;
        public int ZipCode;
        public int ApartmentNumber;

        LocationInfo(int LocationInfoIdInput, int PropertyIdInput, string StreetNameInput, int StreetNumberInput,
            string CityNameInput, string StateNameInput, int ZipCodeInput, int ApartmentNumberInput)
        {
            LocationInfoId = LocationInfoIdInput;
            PropertyId = PropertyIdInput;
            StreetName = StreetNameInput;
            StreetNumber = StreetNumberInput;
            CityName = CityNameInput;
            StateName = StateNameInput;
            ZipCode = ZipCodeInput;
            ApartmentNumber = ApartmentNumberInput;

        }

        public void insertIntoDatabase()
        {

        }


    }
}