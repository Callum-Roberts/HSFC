using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Project
{
    public class list
    {
        private ListExercises1[] contents; 
        private int nextFreeLocation = 0;

        ///private int position = 0;
        public list(int maxSize)
        {
            contents = new ListExercises1[maxSize];
        }



        public bool AddPerson(ListExercises1 theListExercises1)
        {
            if (nextFreeLocation >= contents.Length)
            {
                return false;
            }
            contents[nextFreeLocation] = theListExercises1;
            nextFreeLocation++;
            return true;
        }

        public int GetSeatByName(String theName)   
        {
            // pass back –1 if name is not found in the array 
            for (int position = 0; position < nextFreeLocation; position++)
            {
                if (contents[position].getName() == theName)
                {
                    return position;
                }
            }
            return -1;   /// if we got here then we didn’t find the name 

        }


        public bool RemovePersonByName(String theName)
        {

            int location = GetSeatByName(theName);
            if (location < 0)
            {

                return false;
            }
            else
            {

                nextFreeLocation--;
                contents[location] = contents[nextFreeLocation];

                contents[nextFreeLocation] = null;
                return true;
            }
        }







        






        public int getNumOfPassengers()
        {
            return nextFreeLocation +1;
        }
    }
}
