using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiExtensionEnum
{
    public static class Extension
    {
        public static bool IsItCorrectPin (this string pin)
        {
            if(pin.Length == 7 && pin == pin.ToUpper())
            {
                return true;    
            }
            return false;
        }
      

    }
}
