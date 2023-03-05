using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practice_Exam
{
    public class DriverProvider
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver is null)
                {
                    InitializeDriver();
                }
                return driver;
            }
        }

        private static void InitializeDriver()
        {
            var defaultTimeOut = TimeSpan.FromSeconds(10);
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService());
            driver.Manage().Timeouts().PageLoad = defaultTimeOut;
            driver.Manage().Timeouts().AsynchronousJavaScript = defaultTimeOut;
            driver.Manage().Timeouts().ImplicitWait = defaultTimeOut;
            driver.Manage().Window.Maximize();
        }

        public static void DestroyDriver()
        {
            try
            {
                driver.Close();
                driver.Quit();
            }
            catch
            {
                driver = null;
            }
        }
    }
}