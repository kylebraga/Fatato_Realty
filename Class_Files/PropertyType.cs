using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class PropertyType :IPropertyType
    {
        private int _propertyTypeId;
        private string _propertyTypeDesc;

        public PropertyType(int propertyTypeId, string propertyTypeDesc)
        {
            _propertyTypeId = propertyTypeId;
            _propertyTypeDesc = propertyTypeDesc;
        }

        public int PropertyTypeId
        {
            get
            {
                return _propertyTypeId;
            }
            set
            {
                _propertyTypeId = value;
            }
        }

        public String PropertyTypeDesc 
        {
            get
            {
                return _propertyTypeDesc;
            }
            set
            {
                _propertyTypeDesc = value;
            }
        }
    }
}