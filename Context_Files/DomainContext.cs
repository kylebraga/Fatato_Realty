using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections;
using WebApplication3.Interface_Files;
using WebApplication3.Class_Files;
namespace WebApplication3
{
    public static class DomainContext
    {
        public const String AvailabiltyTypeTableName = "AvailabilityType";
        public const String CardIconTypeTableName = "CardIconType";
        public const String CommercialPropertyTypeTableName = "CommercialPropertyType";
        public const String LaundryTypeTableName = "LaundryType";
        public const String ParkingTypeTableName = "ParkingType";
        public const String PropertyTypeTableName = "PropertyType";
        public const String ResidentialPropertyTypeTableName = "ResidentialPropertyType";
        public const String SmokingTypeTableName = "SmokingType";
        public const String FurnishedTypeTableName = "FurnishedType";
        public const int hasDescription = 2;
        public const int noDescription = 1;
        public static ArrayList AvailabilityTypeList = new ArrayList();

        public static ArrayList CardIconTypeList;
        public static ArrayList FurnishedTypeList;
        public static ArrayList CommercialPropertyTypeList;
        public static ArrayList LaundryTypeList ;
        public static ArrayList ParkingTypeList;
        public static ArrayList PropertyTypeList;
        public static ArrayList ResidentialPropertyTypeList;
        public static ArrayList SmokingTypeList;
    }
}