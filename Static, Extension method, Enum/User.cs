using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiExtensionEnum
{
    internal class User
    {
        public string  Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        
        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                if (value.IsItCorrectPin())
                {
                    pin= value;
                }
                else
                {
                    throw new Exception("Your pin is not correct");
                }

            }
        }
        private string pin;

        public User (string name, string surname, RegistrationMonth registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
           Pin = pin;
        }

        public string GetDetails()
        {
            return $"{Name} {Surname} {RegistrationMonth} {Pin}";
        }
        


    }

}
