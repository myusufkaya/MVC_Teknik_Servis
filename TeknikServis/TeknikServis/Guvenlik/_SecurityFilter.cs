﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TeknikServis.Guvenlik
{
    public class _SecurityFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["Kullanici"] == null
                && !(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName == "Login"))
            {
                filterContext.Result = new RedirectResult("/Login/Index");
                return;
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }

        }
    }
}