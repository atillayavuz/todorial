using System;

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