using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AvatradeTestTask.POMs;

public class MainPagePom: BasePom
{
    public MainPagePom(WebDriver driver) : base(driver) {}
    
    //web elements
    private By _registrationButton = By.XPath("//a[contains(text(), 'Register now')]");
    private By _emailInput = By.XPath("");
    private By _passwordInput = By.XPath("");
    
    //methods
    public void RegistrationButtonClick()
    {
        Click(_registrationButton);
    }

    public void EmailInputSendKeys(string text)
    {
        SendKeys(_emailInput, text);
    }

    public void PasswordInputSendKeys(string text)
    {
        SendKeys(_passwordInput, text);
    }
}