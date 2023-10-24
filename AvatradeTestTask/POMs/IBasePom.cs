using OpenQA.Selenium;

namespace AvatradeTestTask.POMs;
public interface IBasePom
{
    protected void WaitForLoadJs();
    protected void WaitForElementExist(By selector);
    protected void Click(By selector);
    protected bool IsVisible(By selector);
    protected void SendKeys(By selector, string text);
    protected void Clear(By selector);
}