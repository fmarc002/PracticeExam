using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Practice_Exam
{
    public class Select : BaseControl
    {
        public Select()
        {
        }

        public Select(By locator)
            : base(locator)
        { }

        private SelectElement DropSelect => new SelectElement(this.WebElement);

        public void SelectByIndex(int optionIndex)
        {
            this.DropSelect.SelectByIndex(optionIndex);
        }

        public void SelectText(string optionText)
        {
            this.DropSelect.SelectByText(optionText);
        }

        public void SelectValue(string optionValue)
        {
            this.DropSelect.SelectByValue(optionValue);
        }

        public string SelectedOption()
        {
            return this.DropSelect.SelectedOption.Text;
        }

        public IEnumerable<string> Options()
        {
            return this.DropSelect.Options.Select(e => e.Text);
        }
    }
}