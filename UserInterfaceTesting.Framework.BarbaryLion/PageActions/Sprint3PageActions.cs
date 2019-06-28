using System;
using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;

namespace UserInterfaceTesting.Framework.BarbaryLion.PageActions
{
    internal class Sprint3PageActions
    {
        internal Sprint3Page Sprint3Page { get; set; }

        internal Sprint3PageActions(ScenarioContext scenarioContext)
        {
            Sprint3Page = new Sprint3Page(scenarioContext);
        }

        internal void FillOutFormWithRadioButtonAndSubmit(User user)
        {
            SetGender(user);
            Sprint3Page.FirstNameField.SendKeys(user.FirstName);
            Sprint3Page.LastNameField.SendKeys(user.LastName);
            Sprint3Page.SubmitButton.Submit();
        }

        private void SetGender(User user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    Sprint3Page.FemaleGenderRadioButton.Click();
                    break;
                case Gender.Other:
                    Sprint3Page.OtherGenderRadioButton.Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {user.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {user.GenderType} is not implemented.");
            }
        }
    }
}