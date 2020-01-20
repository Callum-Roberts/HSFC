using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class Queue
    {
        private Object[] theItems;
        private int front = 0;                  
        private int back = 0;                   
        private int maxSize = 4;               
        private int length = 0;

        public Queue (int theSize)
        {
            maxSize = theSize;
            theItems = new Object[theSize];
             
        }


        public string Enqueue(Object theObject)
        {
            if (length < maxSize)

            {
                return "True";
            }
            theItems[back] = theObject;
            back = (back + 1) % maxSize;
            length++;
            return "full";
         }
        public bool AddPerson(Object theObject)
        {
            if (length >= maxSize)
            {
                return false;
            }
            contents[nextFreeLocation] = theListExercises1;
            nextFreeLocation++;
            return true;
        }







    }
}

