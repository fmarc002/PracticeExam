using OpenQA.Selenium;

namespace Practice_Exam
{
    public class Label : BaseControl
    {
        public Label()
        {
        }

        public Label(By locator)
            : base(locator)
        { }

        public Label(IWebElement source)
            : base(source)
        { }

        public string Text => this.WebElement.Text;
    }
}