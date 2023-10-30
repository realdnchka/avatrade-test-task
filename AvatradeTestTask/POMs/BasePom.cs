using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AvatradeTestTask.POMs;

public abstract class BasePom: IBasePom
{
    private IWebDriver _driver;
    private WebDriverWait _wait;

    protected BasePom(IWebDriver driver)
    {
        _driver = driver;
        _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    public void WaitForLoadJs()
    {
        _wait.Until(_driver => ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete"));
    }

    public void WaitForElementExist(By selector)
    {
        try
        {
            WaitForLoadJs();
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(selector));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void Click(By selector)
    {
        WaitForElementExist(selector);
        _driver.FindElement(selector).Click();
    }

    public bool IsVisible(By selector)
    {
        try
        {
            WaitForElementExist(selector);
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector));
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public void WaitForElementIsVisible(By selector)
    {
        try
        {
            WaitForElementExist(selector);
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
    public void SendKeys(By selector, string text)
    {
        WaitForElementExist(selector);
        _driver.FindElement(selector).SendKeys(text);
    }
}