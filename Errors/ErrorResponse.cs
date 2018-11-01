using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAssignment.Errors
{
    public class ErrorResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public Error Error { get; set; }
    }
}
