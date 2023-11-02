using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mod2AssignmentB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(AgeEntry.Text, out int age) && CountryPicker.SelectedItem != null)
            {
                Country selectedCountry = (Country)CountryPicker.SelectedItem;
                int legalDrinkingAge = (int)selectedCountry;
                int yearsUntilLegalAge = legalDrinkingAge - age;

                if (yearsUntilLegalAge > 0)
                {
                    ResultLabel.Text = $"You will be able to drink legally in {yearsUntilLegalAge} years in {selectedCountry}.";
                }
                else if (yearsUntilLegalAge == 0)
                {
                    ResultLabel.Text = $"Congratulations! You are of legal drinking age now in {selectedCountry}.";
                }
                else
                {
                    ResultLabel.Text = $"You are already of legal drinking age in {selectedCountry}.";
                }
            }
            else
            {
                ResultLabel.Text = "Please enter a valid age and select a country.";
            }
        }


    }

}
