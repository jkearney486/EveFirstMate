using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace EveModel.Common
{
    public static class Utils
    {
        public static string ParseTypeDescription(string description)
        {
            string html = "";

            Regex doubleBr = new Regex(@"(<br>{2})", RegexOptions.IgnoreCase);
            Regex boldRe = new Regex(@"(<b>{1})(.*)(</b>{1})", RegexOptions.IgnoreCase);
            Regex italicRe = new Regex(@"(<i>{1})(.*)(</i>{1})", RegexOptions.IgnoreCase);
            Regex remainingHtmlRe = new Regex(@"(\<(/?[^\>]+)\>)", RegexOptions.IgnoreCase);

            html = description.Replace("\r\n", "<br>").Replace("\n", "<br>");
            html = doubleBr.Replace(html, "[br]");
            html = html.Replace("<br>", "[br]");
            html = boldRe.Replace(html, "[b]$2[/b]");
            html = italicRe.Replace(html, "[i]$2[/i]");
            html = remainingHtmlRe.Replace(html, "");

            return html;
        }
    }
}
