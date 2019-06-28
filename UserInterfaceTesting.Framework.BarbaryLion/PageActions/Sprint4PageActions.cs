using System;
using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;

namespace UserInterfaceTesting.Framework.BarbaryLion.PageActions
{
    internal class Sprint4PageActions
    {
        internal Sprint4Page Sprint4Page { get; set; }

        internal Sprint4PageActions(ScenarioContext scenarioContext)
        {
            Sprint4Page = new Sprint4Page(scenarioContext);
        }

        internal void FillOutPrimaryContactForm(User user)
        {
            SetPrimaryContactGender(user);
            Sprint4Page.FirstNameField.SendKeys(user.FirstName);
            Sprint4Page.LastNameField.SendKeys(user.LastName);
        }

        internal void FillOutEmergencyContactFormAndSubmit(User emergencyContactUser)
        {
            SetEmergencyContactGender(emergencyContactUser);
            Sprint4Page.FirstNameEmergencyContactField.SendKeys(emergencyContactUser.FirstName);
            Sprint4Page.LastNameEmergencyContactField.SendKeys(emergencyContactUser.LastName);
            Sprint4Page.SubmitEmergencyContactButton.Submit();
        }

        private void SetPrimaryContactGender(User user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    Sprint4Page.FemaleGenderRadioButton.Click();
                    break;
                case Gender.Other:
                    Sprint4Page.OtherGenderRadioButton.Click();
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
                    Sprint4Page.FemaleGenderEmergencyContactRadioButton.Click();
                    break;
                case Gender.Other:
                    Sprint4Page.OtherGenderEmergencyContactRadioButton.Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {emergencyContactUser.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {emergencyContactUser.GenderType} is not implemented.");
            }
        }
    }
}