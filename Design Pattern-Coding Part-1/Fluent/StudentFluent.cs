using Design_Pattern_Coding_Part_1.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Fluent
{
    public class StudentFluent
    {
        private Students students = new Students();

        public StudentFluent NameOfTheStudents(string name)
        {
            students.Name = name;
            return this;
        }
        public StudentFluent StaysOn(string address)
        {
            students.Address = address;
            return this;
        }

        public StudentFluent BiologicalEntities(string gender)
        {
            students.Gender = gender;
            return this;
        }

        public StudentFluent StudysAt(string uni)
        {
            students.University = uni;
            return this; 
        }

    }
}
