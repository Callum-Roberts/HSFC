using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class Queue
    {
        private Queue[] contents;
        private int Front = 0;
        private int back = 0;

        public Queue (int maxSize)
        {
            contents = new Queue[maxSize];
        }


        public bool Enqueue(Person thePerson)
        {
            if (back >= contents.Length)
            {
                return false; 
            }
            contents[back] =  thePerson; 
            back++; 
            return true;
        }

        


        

      
    }
}

