using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Practice_Exam
{
    public static class MethodHelp
    {
        public static string GetAttributeOrEmpty(this IWebElement element, string attributeName)
        {
            try
            {
                string result = element.GetAttribute(attributeName) ?? string.Empty;
                return result;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static bool ExplicitWaitUntil(this IWebDriver driver, Func<bool> func, TimeSpan timeout)
        {
            try
            {
                return new WebDriverWait(driver, timeout).Until(x => func());
            }
            catch
            {
                return false;
            }
        }

        public static bool ElementExists(this IWebElement element)
        {
            try
            {
                return element?.Displayed ?? false;
            }
            catch
            {
                return false;
            }
        }
    }
}