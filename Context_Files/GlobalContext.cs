using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    /// <summary>
    /// Contains my site's global variables.
    /// </summary>
    public static class GlobalContext
    {
      
        /////////////////////////////////////////// Values/////////////////////////////////////
      
        static IUser _currentUser;
        static IAvailabilityType _currentAvailabilityType;
        static ICardIconType _currentCardIconType;
        static ICommercialPropertyType _currentCommercialPropertyType;
        static IFurnishedType _currentFurnishedType;
        static ILaundryType _currentLaundryType;
        static IParkingInformation _currentParkingType;
        static IPropertyType _currentPropertyType;
        static IResidentialPropertyType _currentResidentialPropertyType;
        static ISmokingType _currentSmokingType;

        /////////////////////////////////////////// Get/Set Opps/////////////////////////////////////

        public static IUser CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
            }
        }
        public static IAvailabilityType CurrentAvailabilityType
        {
            get
            {
                return _currentAvailabilityType;
            }
            set
            {
                _currentAvailabilityType = value;
            }
        }
        public static ICardIconType CurrentCardIconType
        {
            get
            {
                return _currentCardIconType;
            }
            set
            {
                _currentCardIconType = value;
            }
        }

        public static ICommercialPropertyType CurrentCommercialPropertyType
        {
            get
            {
                return _currentCommercialPropertyType;
            }
            set
            {
                _currentCommercialPropertyType = value;
            }
        }

         
        public static IFurnishedType CurrentFurnishedType
        {
            get
            {
                return _currentFurnishedType;
            }
            set
            {
                _currentFurnishedType = value;
            }
        }

        public static ILaundryType CurrentLaundryType
        {
            get
            {
                return _currentLaundryType;
            }
            set
            {
                _currentLaundryType = value;
            }
        }
 
        public static IParkingInformation CurrentParkingType
        {
            get
            {
                return _currentParkingType;
            }
            set
            {
                _currentParkingType = value;
            }
        }

        public static IPropertyType CurrentPropertyType
        {
            get
            {
                return _currentPropertyType;
            }
            set
            {
                _currentPropertyType = value;
            }
        }
        public static IResidentialPropertyType CurrentResidentialPropertyType 
        {
            get
            {
                return _currentResidentialPropertyType; 
            }
            set
            {
                _currentResidentialPropertyType = value;
            }
        }
        public static ISmokingType CurrentSmokingType
        {
            get
            {
                return _currentSmokingType;
            }
            set
            {
                _currentSmokingType = value;
            }
        }
    }
}