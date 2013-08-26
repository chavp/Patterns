using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChavpWeb.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString KoTextBoxFor<TModel, TProp>(
            this HtmlHelper<TModel> htmlHelper, 
            Expression<Func<TModel, TProp>> expression,
            object htmlAttributes)
        {

            return global::System.Web.Mvc.Html.InputExtensions.TextBoxFor<TModel, TProp>(
                htmlHelper, expression, htmlAttributes);
        }
    }
}