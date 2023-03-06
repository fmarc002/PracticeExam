using OpenQA.Selenium;

namespace Practice_Exam.PageObject
{
    public class BlockLogin : BasePageObject
    {
        public BlockLogin()
            : base(By.XPath(".//body[contains(@class,'UIPage_LoggedOut')]"))
        { }

        public Label lblNotmeLink => this.Container.NewControl<Label>(By.XPath(".//a[contains(@id,'not_me_link')]"));
        public Label lblErrorPassword => this.Container.NewControl<Label>(By.XPath(".//div[contains(text(),'La contraseña que ingresaste es incorrecta. ')]"));
    }
}