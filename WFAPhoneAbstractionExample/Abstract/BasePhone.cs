using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPhoneAbstractionExample.Abstract
{
    public abstract class BasePhone
    {
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public string Call(string person)
        {
            return person + " calling...";
        }
    }
}
