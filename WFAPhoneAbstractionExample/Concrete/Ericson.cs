using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAPhoneAbstractionExample.Abstract;

namespace WFAPhoneAbstractionExample.Concrete
{
    /// <summary>
    /// Ses çalma özelliği olmayan bir telefon
    /// </summary>
    public class Ericson : BasePhone
    {
        public override string ToString()
        {
            return Model + " " + UnitPrice.ToString("c2");
        }
    }
}
