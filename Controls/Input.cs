using OpenQA.Selenium;

namespace Practice_Exam
{
    public class Input : ClickableControl
    {
        public Input()
        {
        }

        public Input(By locator)
            : base(locator)
        { }

        public string Text => this.WebElement.Text;

        public void Clear() => this.WebElement.Clear();

        public void Write(string value)
        {
            this.WebElement.SendKeys(value);
        }
    }
}