using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public string Profile;
        public List<Animal> SpiritAnimals { get; set; }

        public string ProfilePic
        {
            get { return Profile; }
            set { Profile = IsMale ? "E:\\WPF\\WPFDemo\\images\\chrisPic.jpg" : "E:\\WPF\\WPFDemo\\images\\jessicaPic.jpg"; }
        }
    }

    public enum Animal
    {
        Capybara,
        Platypus,
        Sloth,
        Pangolin
    }
}
