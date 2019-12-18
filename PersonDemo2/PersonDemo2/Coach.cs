using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemo2
{
    public class Coach
    {
        private Person[] contents = new Person[52];
        private int nextFreeLocation;


        public bool AddPerson(Person thePerson)
        {
            if(nextFreeLocation >= contents.Length)
            {
                return false; 
            }
            contents[nextFreeLocation] = thePerson;
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

       // public int GetNumOfPassengers(); 

        
    }
}
