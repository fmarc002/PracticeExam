using OpenQA.Selenium;
using Xunit;

namespace Practice_Exam.PageObject
{
    public class LoginPage : BasePageObject
    {
        public LoginPage()
            : base(By.XPath(".//body[contains(@class,'fbIndex UIPage_LoggedOut')]"))
        { }

        public Input InputEmail => this.Container.NewControl<Input>(By.Id("email"));
        public Input InputPassword => this.Container.NewControl<Input>(By.XPath(".//input[@type='password']"));

        //public Button BtnLogin => this.Container.NewControl<Button>(By.Name("login"));
        public Button BtnLogin => this.Container.NewControl<Button>(By.XPath(".//button[text()= 'Iniciar sesión']"));

        public Button BtnForgetPass => this.Container.NewControl<Button>(By.XPath(".//a[text()= '¿Olvidaste tu contraseña?']"));

        public Label LblTitleFc => this.Container.NewControl<Label>(By.XPath("//img[contains(@alt,'Facebook')]"));

        public Label LblDesc => this.Container.NewControl<Label>(By.TagName("h2"));

        public void IniciarSesion(string email, string password)
        {
            InputEmail.Clear();
            Assert.Empty(InputEmail.Text);
            InputEmail.Write(email);
            InputPassword.Clear();
            Assert.Empty(InputPassword.Text);
            InputPassword.Write(password);

            Assert.True(BtnLogin.Displayed);
            BtnLogin.Click();
        }
    }
}