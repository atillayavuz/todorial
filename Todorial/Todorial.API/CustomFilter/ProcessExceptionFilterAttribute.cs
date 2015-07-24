using System.Net.Http;
using System.Web.Http.Filters;

namespace Todorial.API.CustomFilter
{
    public class ProcessExceptionFilterAttribute : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        { 

            if (actionExecutedContext.Exception is ProcessException)
            { 
                var res = actionExecutedContext.Exception.Message;
                 
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(res),
                    ReasonPhrase = res
                };
                 
                actionExecutedContext.Response = response;
            }
        }
    }
}