using OpenQA.Selenium;

namespace Practice_Exam
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
        }

        protected IWebDriver Driver
        {
            get
            {
                return DriverProvider.Driver;
            }
        }

        protected void GoToUrl(string url)
        {
            this.Driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            DriverProvider.DestroyDriver();
        }

        public void ImplicitWait()
        {
            var defaultTimeOut = TimeSpan.FromSeconds(300);
            this.Driver.Manage().Timeouts().ImplicitWait = defaultTimeOut;
        }
    }
}