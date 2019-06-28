using System;
using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;

namespace UserInterfaceTesting.Framework.BarbaryLion.PageActions
{
    internal class Sprint5Page2Actions
    {
        internal Sprint5Page2 Sprint5Page2 { get; set; }

        internal BasePage BasePage { get; set; }

        internal Sprint5Page2Actions(ScenarioContext scenarioContext)
        {
            Sprint5Page2 = new Sprint5Page2(scenarioContext);
            BasePage = new BasePage(scenarioContext);
        }

        internal BasePage FillOutRadioButtonAndSubmit(Animal animalType)
        {
            SetAnimal(animalType);
            Sprint5Page2.SubmitButton.Submit();
            return BasePage;
        }

        private void SetAnimal(Animal animalType)
        {
            switch (animalType)
            {
                case Animal.Wolves:
                    break;
                case Animal.Crocodiles:
                    Sprint5Page2.CrocodilesRadioButton.Click();
                    break;
                case Animal.Bunnies:
                    Sprint5Page2.BunniesRadioButton.Click();
                    break;
                case Animal.None:
                    throw new Exception($"Request type: {animalType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {animalType} is not implemented.");
            }
        }
    }
}