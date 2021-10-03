using LingoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebLingo.Device;

namespace WebLingo
{
    public static class LingoHelpers
    {
        public static MvcHtmlString ShowWord(this HtmlHelper helper, LingoWord word)
        {
            StringBuilder builder = new StringBuilder();
            WebDevice device = new WebDevice(builder);
            builder.Append("<div class='word'>");
            word.Show(device);
            builder.Append("</div>");

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}