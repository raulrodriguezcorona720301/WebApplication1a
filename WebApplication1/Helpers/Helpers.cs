using System;
using System.Web.Mvc;

namespace WebApplication1.Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString getDate(this HtmlHelper html)
        {
            return MvcHtmlString.Create(DateTime.Now.ToShortDateString());
        }

        public static MvcHtmlString getIdentifier(this HtmlHelper html)
        {
            return MvcHtmlString.Create(Guid.NewGuid().ToString());
        }
    }
}