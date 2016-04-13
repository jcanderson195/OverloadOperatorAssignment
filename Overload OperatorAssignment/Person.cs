using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_OperatorAssignment
{
    class Person
    {
        string firstName;
        string lastName;
        int age;
        DateTime birthday;

        

        public Person(string FirstName, string LastName, int Age, DateTime Birthday)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
            birthday = Birthday;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public static Person operator +(Person name, int Age)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - name.birthday.Year;
            name.age += Age;
            return name;

            
        }

        public void Overloadperson()
        {
            Person Justin = new Person("Justin", "Anderson", 20, new DateTime(1995, 06, 10));
            Justin = Justin + 12;
            Console.WriteLine(Justin.age);
        }


        }
    }

