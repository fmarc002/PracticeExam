using OpenQA.Selenium;

namespace Practice_Exam
{
    public class ClickableControl : BaseControl
    {
        public ClickableControl()
        {
        }

        public ClickableControl(By locator)
            : base(locator)
        { }

        public void Click()
        {
            this.WebElement.Click();
        }
    }
}