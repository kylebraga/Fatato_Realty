using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class LaundryType
    {
        private int _laundryTypeId;
        private string _laundryTypeTypeDesc;

   

        public LaundryType(int laundryTypeId, string laundryTypeTypeDesc)
        {
            _laundryTypeId = _laundryTypeId;
            _laundryTypeTypeDesc = laundryTypeTypeDesc;
        } 
         
        public int LaundryTypeId
        {
            get
            {
                return _laundryTypeId;
            }
            set
            {
                _laundryTypeId = value;
            }
        }

        public String LaundryTypeDesc
        {
            get
            {
                return _laundryTypeTypeDesc;
            }
            set
            {
                _laundryTypeTypeDesc = value;
            }
        }
    }
}