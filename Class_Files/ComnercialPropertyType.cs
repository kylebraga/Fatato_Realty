using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class ComnercialPropertyType : ICommercialPropertyType
    {
        private int _commercialPropertyTypeId;
        private string _commercialPropertyTypeDesc;

        public ComnercialPropertyType(int commercialPropertyTypeId, string commercialPropertyTypeDesc)
        {
            _commercialPropertyTypeId = commercialPropertyTypeId;
            _commercialPropertyTypeDesc = commercialPropertyTypeDesc;
        }

        public int CommercialPropertyTypeId
        {
            get
            {
                return _commercialPropertyTypeId;
            }
            set
            {
                _commercialPropertyTypeId = value;
            }
        }

        public String CommercialPropertyTypeDesc
        {
            get
            {
                return _commercialPropertyTypeDesc;
            }
            set
            {
                _commercialPropertyTypeDesc = value;
            }
        }
    }
}