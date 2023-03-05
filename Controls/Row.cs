using OpenQA.Selenium;

namespace Practice_Exam
{
    public class Row : ClickableControl
    {
        public Row()
        {
        }

        public Row(By locator)
            : base(locator)
        { }
    }
}