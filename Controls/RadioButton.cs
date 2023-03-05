using OpenQA.Selenium;

namespace Practice_Exam
{
    public class RadioButton : ClickableControl
    {
        public RadioButton()
        {
        }

        public RadioButton(By locator)
            : base(locator)
        { }
    }
}