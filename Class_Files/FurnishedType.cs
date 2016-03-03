using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class FurnishedType : IFurnishedType
    {
        private int _furnishedTypeTypeId;
        private string _furnishedTypeTypeDesc;

        public FurnishedType(int furnishedTypeTypeId, string furnishedTypeTypeDesc)
        {
            _furnishedTypeTypeId = furnishedTypeTypeId;
            _furnishedTypeTypeDesc = furnishedTypeTypeDesc;
        } 

        public int FurnishedTypeId
        {
            get
            {
                return _furnishedTypeTypeId;
            }
            set
            {
                _furnishedTypeTypeId = value;
            }
        }

        public String FurnishedTypeDesc
        {
            get
            {
                return _furnishedTypeTypeDesc;
            }
            set
            {
                _furnishedTypeTypeDesc = value;
            }
        }
    }
}