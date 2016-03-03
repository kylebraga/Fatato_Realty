using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class CardIconType : ICardIconType
    {
        private int _cardIconTypeId;
        private string _cardIconName;
        private string _cardIconFileName;

        public CardIconType(int cardIconTypeId, string cardIconName, string cardIconFileName)
        {
            _cardIconTypeId = cardIconTypeId;
            _cardIconName = cardIconName;
            _cardIconFileName = cardIconFileName;
        }

        public int CardIconTypeId
        {
            get
            {
                return _cardIconTypeId;
            }
            set
            {
                _cardIconTypeId = value;
            }
        }
        public string CardIconName
        {
            get
            {
                return _cardIconName;
            }
            set
            {
                _cardIconName = value;
            }
        }
        public string CardIconFileName
        {
            get
            {
                return _cardIconFileName;
            }
            set
            {
                _cardIconFileName = value;
            }
        }
    }
}