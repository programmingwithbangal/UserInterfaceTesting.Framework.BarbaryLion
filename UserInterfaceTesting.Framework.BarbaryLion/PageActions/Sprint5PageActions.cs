﻿using System;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;

namespace UserInterfaceTesting.Framework.BarbaryLion.PageActions
{
    internal class Sprint5PageActions
    {
        internal Sprint5Page Sprint5Page { get; set; }

        internal Sprint5Page2 Sprint5Page2 { get; set; }

        private Actions WebDriverActions => new Actions(Sprint5Page.Driver);

        internal Sprint5PageActions(ScenarioContext scenarioContext)
        {
            Sprint5Page = new Sprint5Page(scenarioContext);
            Sprint5Page2 = new Sprint5Page2(scenarioContext);
        }

        internal void FillOutPrimaryContactForm(User user)
        {
            SetPrimaryContactGender(user);
            Sprint5Page.FirstNameField.SendKeys(user.FirstName);
            Sprint5Page.LastNameField.SendKeys(user.LastName);
        }

        internal Sprint5Page2 FillOutEmergencyContactFormAndSubmit(User emergencyContactUser)
        {
            SetEmergencyContactGender(emergencyContactUser);
            Sprint5Page.FirstNameEmergencyContactField.SendKeys(emergencyContactUser.FirstName);
            Sprint5Page.LastNameEmergencyContactField.SendKeys(emergencyContactUser.LastName);
            Sprint5Page.SubmitEmergencyContactButton.Submit();
            return Sprint5Page2;
        }

        private void SetPrimaryContactGender(User user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    Sprint5Page.FemaleGenderRadioButton.Click();
                    break;
                case Gender.Other:
                    Sprint5Page.OtherGenderRadioButton.Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {user.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {user.GenderType} is not implemented.");
            }
        }

        private void SetEmergencyContactGender(User emergencyContactUser)
        {
            switch (emergencyContactUser.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    WebDriverActions.MoveToElement(Sprint5Page.FemaleGenderEmergencyContactRadioButton).Click();
                    break;
                case Gender.Other:
                    WebDriverActions.MoveToElement(Sprint5Page.OtherGenderEmergencyContactRadioButton).Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {emergencyContactUser.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {emergencyContactUser.GenderType} is not implemented.");
            }
        }
    }
}