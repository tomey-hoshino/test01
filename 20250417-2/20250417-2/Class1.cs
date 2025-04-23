using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData
{
    class Class1
    {
        private string? _name;
        private DateTime _birthday;

        public string? Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Birthday
        { 
            get { return _birthday; } 
            set { _birthday = value; }
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - _birthday.Year;

            if(
                DateTime.Today.Month<_birthday.Month||
                DateTime.Today.Month==_birthday.Month&&
                DateTime.Today.Day<_birthday.Day
                )
            {
                age--;
            }
            return age;
        }
    }
}
