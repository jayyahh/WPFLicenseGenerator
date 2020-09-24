using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFDemo
{
    public partial class ContactCard : Window
    {
        public PersonalInfo person;
        public ContactCard(PersonalInfo info)
        {
            InitializeComponent();

            person = info;
            setBindings();
        }

        private void setBindings()
        {
            setNameBinding();
            setGenderBinding();
            setProfilePicBinding();
            setBirthdateBinding();
            setFavoriteFoods();
        }

        private void setNameBinding()
        {
            var firstNameBinding = new Binding();
            firstNameBinding.Source = person.FirstName + " " + person.LastName;
            fullName.SetBinding(TextBlock.TextProperty, firstNameBinding);
        }

        private void setGenderBinding()
        {
            var genderBinding = new Binding();
            genderBinding.Source = person.IsMale ? "Male" : "Female";
            gender.SetBinding(TextBlock.TextProperty, genderBinding);
        }

        private void setProfilePicBinding()
        {
            var profileBinding = new Binding();
            profileBinding.Source = person.IsMale ? "E:\\WPF\\WPFDemo\\images\\chrisPic.jpg" : "E:\\WPF\\WPFDemo\\images\\galPic.jpg";
            profilePic.SetBinding(Image.SourceProperty, profileBinding);
        }

        private void setBirthdateBinding()
        {
            var birthdateBinding = new Binding();
            birthdateBinding.Source = person.Birthday.Year + "." + person.Birthday.Month + "." + person.Birthday.Day;
            birthdate.SetBinding(TextBlock.TextProperty, birthdateBinding);
        }

        private void setFavoriteFoods()
        {
            var foodBinding = new Binding();
            if (person.SpiritAnimals.Count != 0)
            {
                foodBinding.Source = "Spirit Animals: ";
                for (var i = 0; i < person.SpiritAnimals.Count; i++)
                {
                    if (i != 0)
                    {
                        foodBinding.Source += ", ";
                    }
                    foodBinding.Source += person.SpiritAnimals.ElementAt(i).ToString();
                }
            } else
            {
                foodBinding.Source = "Spirit Animals: None. I am lame";
            }
            favoriteFoods.SetBinding(TextBlock.TextProperty, foodBinding);
        }
    }
}
