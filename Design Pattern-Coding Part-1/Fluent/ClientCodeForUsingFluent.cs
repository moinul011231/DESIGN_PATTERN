using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Fluent
{
    public class ClientCodeForUsingFluent
    {
        Students students = new Students {
            Name = "Adil",
            Gender = "Male",
            Address = "Dhaka",
            University = "UIU"
        };

        StudentFluent stud2 = new StudentFluent().NameOfTheStudents("Rajit")
                                                 .StaysOn("Bramonbaria")
                                                 .StudysAt("IUB")
                                                 .BiologicalEntities("Male");
    }
}
