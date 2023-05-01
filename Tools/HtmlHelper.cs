﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerbiSharp.Infrastructure.BaseInfrastructure.Tools
{
    public static class HtmlHelper
    {
        public static Dictionary<string, string> GetKeyValueFromHtml(string html, string xPath, List<string> names)
        {
            var htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(html);

            HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(xPath);

            IEnumerable<KeyValuePair<string, string>> keyValuePairs = nodes.
                Where(n =>
                    names.Contains(n.GetAttributeValue("name", string.Empty))).
                Select(n => KeyValuePair.Create(
                    n.GetAttributeValue("name", string.Empty),
                    n.GetAttributeValue("value", string.Empty)
                    ));

            return new Dictionary<string, string>(keyValuePairs);
        }
    }
}
