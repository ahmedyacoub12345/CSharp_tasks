using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task4
{
    internal class Informations
    {
        public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public int ID;
        public string Phone;

        public Informations(int age, string gender, string name, string email, int id, string phone)
        {
            if (age >= 18 && age <= 60)
            {
                this.Age = age;
            }
            else
            {
                throw new ArgumentException("Age must be between 18 and 60.");
            }


            Gender = gender;
            Name = name;
            Email = email;
            ID = id;

            if (phone.StartsWith("077") || phone.StartsWith("078") || phone.StartsWith("079"))
                Phone = phone;
            else
                throw new ArgumentException("Phone number must start with 077, 078, or 079.");

        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }
}
