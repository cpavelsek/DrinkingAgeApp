using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DrinkingAge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        string selectedCountry;
        

         public void HandleCheck(object sender, System.EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            selectedCountry = rb.Content.ToString();

           // Lbl_Birthday.Text = "You chose: " + rb.GroupName + ": ";


        }


        void CaclulateDatePicker(object sender, System.EventArgs e)
        {
            //var dateDif = DateTime.Today.Subtract(Inp_Birthday.Date);

            var desiredCountry = selectedCountry;

            var currentYear = DateTime.Today.Year;

            var canDrink = currentYear - Inp_Birthday.Date.Year;


            if(desiredCountry == "Germany")
            {
                if (canDrink >= 16)
                {
                    Lbl_Birthday.Text = $"You can drink! You are {canDrink} years old, and can drink in Germany";
                }
                else
                {
                    Lbl_Birthday.Text = $"You can't drink! You are {canDrink} years old, you need to be at least 16 in Germany.";
                }
            }
            if (desiredCountry == "Japan")
            {
                if (canDrink >= 20)
                {
                    Lbl_Birthday.Text = $"You can drink! You are {canDrink} years old, and can drink in Japan";
                }
                else
                {
                    Lbl_Birthday.Text = $"You can't drink! You are {canDrink} years old, you need to be at least 20 in Japan.";
                }
            }
            if (desiredCountry == "South Africa")
            {
                if (canDrink >= 18)
                {
                    Lbl_Birthday.Text = $"You can drink! You are {canDrink} years old, and can drink in South Africa";
                }
                else
                {
                    Lbl_Birthday.Text = $"You can't drink! You are {canDrink} years old, you need to be at least 18 in South Africa.";
                }
            }
            if (desiredCountry == "USA")
            {
                if (canDrink >= 21)
                {
                    Lbl_Birthday.Text = $"You can drink! You are {canDrink} years old, and can drink in USA";
                }
                else
                {
                    Lbl_Birthday.Text = $"You can't drink! You are {canDrink} years old, you need to be at least 21 in USA.";
                }
            }

            //if (canDrink >= 21)
            //{
            //    Lbl_Birthday.Text = $"You can drink! You are {canDrink} years old";
            //}
            //else
            //{
            //    Lbl_Birthday.Text = $"You can't drink! You are {canDrink} years old";
            //}





        }


        void Button_Clicked(object sender, System.EventArgs e)
        {
            //This was for part A of Lab
            //double yearsUntil21 = 21 - Int32.Parse(Inp_age.Text)

           

            double age = 2021 - Int32.Parse(Inp_YearBorn.Text);
            double yearsTil21 = 21 - age;

            if (age >= 21)
            {
                Lbl_DrinkAge.Text = "You can legally drink already.  You are " + age;

            }
            else
            {
                Lbl_DrinkAge.Text = $" Years until you can legally drink in the US. {yearsTil21}" ;
            }

        }

        
    }
}
