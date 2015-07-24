using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todorial.API.CustomFilter
{
    public class ProcessException :Exception
    {
        public ProcessException(string message)
            : base(message)
        {

        }
    }
}