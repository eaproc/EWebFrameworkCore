using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.Requests
{
    public class InputValidationFailedException:Exception
    {
        public InputValidationFailedException(Dictionary<string, string> errors) :base("Fill the required fields!")
        {
            this.Errors = errors;
        }

        public Dictionary<string, string> Errors { get; }
    }
}
