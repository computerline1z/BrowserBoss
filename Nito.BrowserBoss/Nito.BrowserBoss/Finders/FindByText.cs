using System.Collections.Generic;
using OpenQA.Selenium;

namespace Nito.BrowserBoss.Finders
{
    /// <summary>
    /// Finds elements by their text value.
    /// </summary>
    public sealed class FindByText : IFind
    {
        IReadOnlyCollection<IWebElement> IFind.Find(ISearchContext context, string searchText)
        {
            return context.FindElements(By.XPath(".//*[text() = " + Utility.XPathString(searchText) + "]"));
        }
    }
}