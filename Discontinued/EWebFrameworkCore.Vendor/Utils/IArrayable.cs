using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.Utils
{
   public interface IArrayable
    {
        IEnumerable<object> ToArray();
    }
}
