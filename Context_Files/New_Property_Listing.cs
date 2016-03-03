using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Context_Files
{
    public static class New_Property_Listing
    {
        // Street Info
        public static string streetName;
        public static string streetNum;
        public static string appartNum;
        public static string city;
        public static string state;
        public static string zip;

        // Property Type
        public static string propCat;
        public static string propType;

        //House Specs
        public static string bedNum;
        public static string bathNum;
        public static string squareFeet;

        //Finances
        public static string rent;
        public static string securityDeposit;

        //Description
        public static string description;

        //Features
        public static string smokingType;
        public static string parkingType;
        public static string furnishType;
        public static string laundryType;
        public static string publicTransType;
        public static string numParkSpots;

        //Availability
        public static string availabilityType;
        public static string availDate;
        public static string leaseDuration;

        //Pets
        public static string allowedPetString;

        //Utilities
        public static bool isBasicUtilityCoverage;
        public static string basicUtilCoverage;
        public static string heatUtil;
        public static string waterUtil;
        public static string electricUtil;
        public static string garbageUtil;
        public static string sewerUtil;
        public static string lawnUtil;
        public static string snowUtil;
        public static string cableUtil;
        public static string averageUtilCost;

        //Display
        public static string displayIconString;


    }

}