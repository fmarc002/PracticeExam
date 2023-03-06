using Practice_Exam.PageObject;
using Xunit;

namespace Practice_Exam
{
    public class Class1 : BaseTest
    {
        private const String urlLogin = "https://es-la.facebook.com/";

        public Class1()
        {
        }

        [Fact]
        public void test_LoginInvalid()
        {
            this.GoToUrl(urlLogin);
            var LoginPage = new LoginPage();
            Assert.True(LoginPage.HasLoaded());

            LoginPage.IniciarSesion("flormarc46@hotmail.com", "abc123");
            var BlockLogin = new BlockLogin();
            Assert.True(BlockLogin.HasLoaded());
            Assert.True(BlockLogin.lblNotmeLink.Displayed);
            Assert.Contains("La contraseña que ingresaste es incorrecta", BlockLogin.lblErrorPassword.Text);
        }
    }
}