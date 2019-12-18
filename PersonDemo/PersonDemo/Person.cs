using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemo
{
    public class Person
    {
        private String name = "";

        private int age = 0;

        // setName procedure allows a user to set a Person's name
        public void setName(String theString)
        {
            name = theString;
        }

        //getName function returns a Person's name
        public String getName()
        {
            return name;
        }

        // setAge procedure allows a user to set a Person's age
        public void setAge(int theAge)
        {
            age = theAge;
        }

        //getAge function returns a Person's age
        public int getAge()
        {
            return age;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return this.getName() + " is aged " + this.getAge();
        }

    }
}
