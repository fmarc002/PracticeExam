using OpenQA.Selenium;

namespace Practice_Exam
{
    public class Button : ClickableControl
    {
        public Button()
        {
        }

        public Button(By locator)
            : base(locator)
        { }
    }
}