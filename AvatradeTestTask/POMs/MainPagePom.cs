using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AvatradeTestTask.POMs;

public class MainPagePom: BasePom
{
    public MainPagePom(IWebDriver driver) : base(driver) {}
    
    //selectors
    private By _registrationButton = By.XPath("//div[@class='CreateAccount']/div[contains(@class, 'btn-header')]//a[contains(text(), 'Create my account') or contains(text(), 'Register now') or contains(text(), 'Open trading account')]");
    private By _emailInput = By.XPath("//form[@class='form-registry-popup']//input[@type='email']");
    private By _passwordInput = By.XPath("//input[@type='password']");
    private By _createAccountButton = By.XPath("//div[@class='submit-button']//button");
    
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

    public void CreateAccountButtonClick()
    {
        Click(_createAccountButton);
    }
}