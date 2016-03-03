using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    
    public class SmokingType : ISmokingType
    {
        private int _smokingTypeId;
        private string _smokingTypeDesc;

        public SmokingType(int smokingTypeId, string smokingTypeDesc)
        {
             _smokingTypeId = smokingTypeId;
             _smokingTypeDesc = smokingTypeDesc;
        }

        
        public int SmokingTypeId
        {
            get
            {
                return _smokingTypeId;
            }
            set
            {
                _smokingTypeId = value;
            }
        }
        public String SmokingTypeDesc
        {
            get
            {
                return _smokingTypeDesc;
            }
            set
            {
                _smokingTypeDesc = value;
            }
        }
    }
}