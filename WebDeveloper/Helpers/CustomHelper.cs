using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            var cadena = "<span>{0}</span>";
            if (price == 0)
            {
                cadena = string.Format(cadena, "Free!!!!");
            }
            else {
                cadena = string.Format(cadena, price);
            }
            return new HtmlString(cadena);
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            var result = string.Empty;
            if (price == 0)
            {
                result = "<span>Free!!!</span>";
            }
            else {
                result = $"<span>{price.ToString("C")}</span>";
            }
            return new HtmlString(result);
        }

        public static IHtmlString DisplayPriceExtension1(this HtmlHelper helper, double price)
        {
            return new HtmlString($"<span>{ ((price == 0) ? "Free!!!" : price.ToString("C"))}</span>");
        }

        public static IHtmlString DisplayStaticDateOrNull(DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }

        public static IHtmlString DisplayDateOrNull(this HtmlHelper helper, DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }

        private static string GetHtmlForDate(DateTime? date)
        {
            return date == null ? "<span>No Registrado</span>" : $"<span>{string.Format("{0:dd-MM-yyyy}", date)}</span>";
        }
    }
}
