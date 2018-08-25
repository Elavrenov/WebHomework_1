using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHomework.Handlers
{
    /// <summary>
    /// Summary description for UserInfoHandler
    /// </summary>
    public class UserInfoHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string result = "<p>Ваш IP: " + context.Request.UserHostAddress + "</p>";
            result += "\n<p>UserAgent: " + context.Request.UserAgent + "</p>";
            context.Response.Write(result);
            context.Response.WriteFile("abc.abc");
        }

        public bool IsReusable => false;
    }
}