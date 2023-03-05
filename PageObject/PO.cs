using OpenQA.Selenium;

namespace Practice_Exam.PageObject
{
    public class PO : BasePageObject
    {
        public PO()
            : base(By.XPath(""))
        { }

        public Input Inputname => this.Container.NewControl<Input>(By.XPath(""));
    }
}