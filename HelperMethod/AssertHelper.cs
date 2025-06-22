using System;
using HtmlAgilityPack;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Legacy;

class Program
{
    static void Main()
    {
        var filePath = @"D:\porter\learning\DynamicItinerary\TestData\Culture_enUS.html";

        var expectedflightNumbers = new List<string> { "Ottawa, ON (YOW)", "PD 2205" };
        var selectors = new List<string> { "//span[contains(text(),'Arrival time')]/ancestor::table[1]//p[contains(text(), 'Ottawa')]", $"//p[normalize-space()='PD 2205']" };

        // AssertHelper.assertHTML(filePath, selectors, expectedflightNumbers);
        var selectors1 = new CultureENUSSelector();
        AssertHelper.ExtractTextFromSelectors(filePath, selectors1);
    }

    public static class AssertHelper
    {
        public static void assertHTML(string filePath, List<string> xpaths, List<string> expectedResult)
        {
            var doc = new HtmlDocument();
            doc.Load(filePath);

            var actualResult = new List<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                    throw new ArgumentException("File path is null or empty.");

                if (xpaths == null || xpaths.Count == 0)
                    throw new ArgumentException("XPath list is null or empty.");

                if (expectedResult == null || expectedResult.Count == 0 || expectedResult.Count != xpaths.Count)
                {
                    throw new ArgumentException("actual list is empty or actual list and xpath list not have same length");
                }

                foreach (var xpath in xpaths)
                {
                    var nodes = doc.DocumentNode.SelectNodes(xpath);
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            actualResult.Add(node.InnerText.Trim());
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.Write("[ERR] " + e.Message);
            }
            CollectionAssert.AreEquivalent(expectedResult, actualResult);
        }


        public static List<string> ExtractTextFromSelectors<T>(string filePath, T selectorClass) where T : ISelectorProvider
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path is null or empty.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var results = new List<string>();

            var selectors = selectorClass.getAllSelectors();

            foreach (var xpath in selectors)
            {
                var nodes = doc.DocumentNode.SelectNodes(xpath);
                if (nodes != null)
                {
                    foreach (var node in nodes)
                    {
                        results.Add(node.InnerText.Trim());

                    }
                }
            }
            Console.WriteLine(string.Join(",", results));
            return results;
        }
    }
}


