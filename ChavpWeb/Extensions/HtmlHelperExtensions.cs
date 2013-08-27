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
            object htmlAttributes, bool editable)
        {
            MvcHtmlString html = default(MvcHtmlString);
            RouteValueDictionary routeValues = new RouteValueDictionary(htmlAttributes);
            string name = ExpressionHelper.GetExpressionText(expression);

            if (editable)
            {
                routeValues.Add("data-bind", string.Format("value: {0}", name));

                html = System.Web.Mvc.Html.InputExtensions.TextBoxFor(htmlHelper, expression, routeValues);
            }
            else
            {
                routeValues.Add("class", "readOnly");
                routeValues.Add("readonly", "read-only");

                html = System.Web.Mvc.Html.InputExtensions.TextBoxFor(htmlHelper, expression, routeValues);
            }
            return html;
        }

        public static MvcHtmlString KoTextActionLink(
                 this HtmlHelper htmlHelper,
                 string linkText,
                 string actionName
            )
        {
            MvcHtmlString html = default(MvcHtmlString);
            RouteValueDictionary htmlAttributes = new RouteValueDictionary();

            htmlAttributes.Add("data-bind", string.Format("click: {0}", actionName));

            html = System.Web.Mvc.Html.LinkExtensions.ActionLink(htmlHelper, linkText, "#", null, htmlAttributes);

            return html;
        }
    }
}