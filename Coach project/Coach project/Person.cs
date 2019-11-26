using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_project
{
    public class Person
    {
        private String name = "";

        private int age = 0;


        public void setName(String theString)
        {
            name = theString;
        }

        public String getName()
        {
            return name;
        }

        public void setAge(int theAge)
        {
            age = theAge;
        }

        public int getAge()
        {
            return age;
        }

        public override String ToString()

        {

            return this.getName() + " is aged " + this.getAge();

        }
    }
}
