using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_project
{
    public class Coach
    {
        private Person[] contents = new Person[4];
        private int nextFreeLocation=0;
        ///private int NumOfPasserngers;
        private int position = 0; 
        public bool AddPerson(Person thePerson)
        {
            if (nextFreeLocation >= contents.Length)
            {
                return false;
            }
            contents[nextFreeLocation] = thePerson;
            nextFreeLocation++; 
            return true;
        }




        public bool RemovePerson(Person thePerson)
        {
            if (nextFreeLocation >= contents.Length)
            {
                return false;
            }
            contents[nextFreeLocation] = thePerson;
            return true;
        }

        public int GetSeatByName(String theName)  

        {

            

            for (position = 0; position < nextFreeLocation; position++)

            {

                if (contents[position].getName () == theName)

                {

                    return position;

                }

            }

            return -1;  

        }





        public int getNumOfPassengers()
        {
            return nextFreeLocation; 
        }
    }
}
