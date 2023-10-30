using AvatradeTestTask.Helpers.Models;
using AvatradeTestTask.POMs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AvatradeTestTask.Tests;

[TestClass]
public class RegistrationTest: BaseTest
{
    static IEnumerable<object[]> UsersTestSetup
    {
        get
        {
            return new[]
            {
                new object[]
                {
                    new User { FirstName = "First", LastName = "Last", Email = "maisifsdfdss@mail.cor", Password = "Password1!", DateOfBirth = new DateTime(1990, 10, 10), Country = "France", City = "Paris", StreetName = "Street", BuildingNumber = "10", ZipCode = "10001", PhoneNumber = "3333333" },
                },
                new object[]
                {
                    new User { FirstName = "First", LastName = "Last", Email = "dsjfdjsfjsd@mail.or", Password = "Password1!", DateOfBirth = new DateTime(1990, 10, 10), Country = "Afghanistan", City = "Kabul", StreetName = "Street", BuildingNumber = "10", ZipCode = "10001", PhoneNumber = "3333333" },
                }
            };
        }
    }
    [TestMethod]
    [DynamicData(nameof(UsersTestSetup))]
    public void Registration(User user)
    {
        //Arrange
        MainPagePom mainPagePom = new(driver);
        ConfirmRegistrationPopupPom confirmRegistrationPopupPom = new(driver);
        mainPagePom.WaitForElementIsVisible(By.XPath("//div[@id='riskStickyDisclamer']/p"));
        
        //Act
        mainPagePom.RegistrationButtonClick();
        mainPagePom.EmailInputSendKeys(user.Email);
        mainPagePom.PasswordInputSendKeys(user.Password);
        mainPagePom.CreateAccountButtonClick();
        
        //TODO country selector doesn't work :(
        confirmRegistrationPopupPom.CountryInputSendKeys(user.Country);
        confirmRegistrationPopupPom.CountryOptionClick(user.Country);
        confirmRegistrationPopupPom.FirstNameInputSendKeys(user.FirstName);
        confirmRegistrationPopupPom.LastNameInputSendKeys(user.LastName);
        confirmRegistrationPopupPom.BirthdayInputSendKeys(user.DateOfBirth.ToString("ddMMyyyy"));
        confirmRegistrationPopupPom.CityInputSendKeys(user.City);
        confirmRegistrationPopupPom.StreetNameInputSendKeys(user.StreetName);
        confirmRegistrationPopupPom.BuildingNumberInputSendKeys(user.BuildingNumber);
        confirmRegistrationPopupPom.ZipCodeInputSendKeys(user.ZipCode);
        confirmRegistrationPopupPom.PhoneNumberInputSendKeys(user.PhoneNumber);
        confirmRegistrationPopupPom.ContinueButtonClick();

        confirmRegistrationPopupPom.OccupationOrBusinessSelectClick();
        confirmRegistrationPopupPom.SelectOption("Engineering");
        confirmRegistrationPopupPom.EmploymentStatusSelectClick();
        confirmRegistrationPopupPom.SelectOption("Employed");
        confirmRegistrationPopupPom.SourceOfTradeFundsSelectClick();
        confirmRegistrationPopupPom.SelectOption("Employment");
        confirmRegistrationPopupPom.EstimatedAnnualIncomeSelectClick();
        confirmRegistrationPopupPom.SelectOption("Less than 25,000");
        confirmRegistrationPopupPom.SavingsAndInvestmentsSelectClick();
        confirmRegistrationPopupPom.SelectOption("Less than 50,000");
        confirmRegistrationPopupPom.AmountIntendInvestingEveryYearSelectClick();
        confirmRegistrationPopupPom.SelectOption("Less than 25,000");
        confirmRegistrationPopupPom.ContinueButtonClick();

        try
        {
            confirmRegistrationPopupPom.RelevantExperienceYesButtonClick();
            confirmRegistrationPopupPom.NumOfTimesTradingSelectClick();
            confirmRegistrationPopupPom.SelectOption("11-25");
            confirmRegistrationPopupPom.WhatWasTheAverageSizeOfTradesSelectClick();
            confirmRegistrationPopupPom.SelectOption("25,000-50,000");
            confirmRegistrationPopupPom.TradingWithLeverageAppliesSelectClick();
            confirmRegistrationPopupPom.SelectOption("It may increase profits or losses");
            confirmRegistrationPopupPom.TradingWithLeverageMaximumPositionSelectClick();
            confirmRegistrationPopupPom.SelectOption("$50,000");
            confirmRegistrationPopupPom.OpenPositionAutomaticallyCloseSelectClick();
            confirmRegistrationPopupPom.SelectOption(
                "The market is moving against my position and I don’t have enough equity to meet the margin requirement");
            confirmRegistrationPopupPom.WhyTradeWithUsSelectClick();
            confirmRegistrationPopupPom.SelectOption("Speculation");
            confirmRegistrationPopupPom.ConfirmationCheckboxClick();
            confirmRegistrationPopupPom.ContinueButtonClick();
        }
        catch (NoSuchElementException) { }

        confirmRegistrationPopupPom.TermsAndConditionsSwitchClick();
        confirmRegistrationPopupPom.ContinueButtonClick();
        
        //Assert
        Assert.IsTrue(driver.FindElement(By.ClassName("rocket-container")).Displayed);
    }
}