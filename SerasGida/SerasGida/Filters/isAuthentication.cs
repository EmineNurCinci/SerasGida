using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerasGida.Filters
{
    public class isAuthentication : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserName"] == null)
            {
                var id = filterContext.HttpContext.Request.Url.AbsoluteUri.ToString();
                string url = "~/Login/Index";
                filterContext.Result = new RedirectResult(url);
            }
        }
    }
}