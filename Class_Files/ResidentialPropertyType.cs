using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class ResidentialPropertyType : IResidentialPropertyType
    {
        private int _residentialPropertyTypeId;
        private string _residentialPropertyTypeDesc;

        public ResidentialPropertyType(int residentialPropertyTypeId, string residentialPropertyTypeDesc)
        {
            _residentialPropertyTypeId = residentialPropertyTypeId;
            _residentialPropertyTypeDesc = residentialPropertyTypeDesc;
        }
        public int ResidentialTypeId
        {
            get
            {
                return _residentialPropertyTypeId;
            }
            set
            {
                _residentialPropertyTypeId = value;
            }
        }

        public String ResidentialTypeDesc
        {
            get
            {
                return _residentialPropertyTypeDesc;
            }
            set
            {
                _residentialPropertyTypeDesc = value;
            }
        }
    }
}