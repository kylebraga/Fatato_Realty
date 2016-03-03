using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Class_Files
{
    public interface ICardIconType
    {
        int CardIconTypeId { get; set; }
        string CardIconName { get; set; }
        string CardIconFileName { get; set; }
    }
}
