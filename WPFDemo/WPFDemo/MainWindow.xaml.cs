using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            createAgeComboBox();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkComplete())
            {
                var person = createPerson();
                showContactCard(person);
            }
        }

        private void createAgeComboBox()
        {
            var genders = new List<ImageAndText>();
            genders.Add(new ImageAndText("E:\\WPF\\WPFDemo\\images\\maleIcon.png", "Male"));
            genders.Add(new ImageAndText("E:\\WPF\\WPFDemo\\images\\femaleIcon.png", "Female"));
            genderComboBox.ItemsSource = genders;
        }

        private PersonalInfo createPerson()
        {
            var person = new PersonalInfo();
            person.FirstName = firstNameText.Text;
            person.LastName = lastNameText.Text;
            person.IsMale = genderComboBox.SelectedIndex == 0 ? true : false;
            person.Age = (int)ageSlider.Value;
            person.Birthday = (System.DateTime)dateCalendar.SelectedDate;
            List<Animal> spiritAnimals = new List<Animal>();
            if ((bool)Capybara.IsChecked)
                spiritAnimals.Add(Animal.Capybara);
            if ((bool)Pangolin.IsChecked)
                spiritAnimals.Add(Animal.Pangolin);
            if ((bool)Sloth.IsChecked)
                spiritAnimals.Add(Animal.Sloth);
            if ((bool)Platypus.IsChecked)
                spiritAnimals.Add(Animal.Platypus);
            person.SpiritAnimals = spiritAnimals;

            return person;
        }

        private void showContactCard(PersonalInfo person)
        {
            ContactCard contactCard = new ContactCard(person);
            contactCard.Show();
        }

        private bool checkComplete()
        {
            if (firstNameText.Text == "")
            {
                MessageBox.Show("Please enter first name.");
                return false;
            }
            if (lastNameText.Text == "")
            {
                MessageBox.Show("Please enter last name");
                return false;
            }
            if (genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select gender");
                return false;
            }
            if (dateCalendar.SelectedDate == null || dateCalendar.SelectedDate > DateTime.UtcNow)
            {
                MessageBox.Show("Please select date of birth. Cannot be born in the future");
                return false;
            }
            var animalSelected = 0;
            if ((bool)Capybara.IsChecked)
                animalSelected++;
            if ((bool)Sloth.IsChecked)
                animalSelected++;
            if ((bool)Pangolin.IsChecked)
                animalSelected++;
            if ((bool)Platypus.IsChecked)
                animalSelected++;
            if (animalSelected > 2)
            {
                MessageBox.Show("Please select up to two only");
                return false;
            }
            return true;
        }
    }

    public class ImageAndText
    {
        public string Picture { get; set; }
        public string Text { get; set; }

        public ImageAndText(string picture, string text)
        {
            Picture = picture;
            Text = text;
        }
    }
}
