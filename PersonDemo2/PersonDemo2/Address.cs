using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemo2
{
     public class Address
    {
        private String houseNameNumber;
        private String street;
        private String county;
        private String postCode;

      
        public Address(String thehouseNameNumber,
                 String theStreet,
                 String theCounty,
                 String thePostCode)
        {
            houseNameNumber = thehouseNameNumber;
            street = theStreet;
            county = theCounty;
            postCode = thePostCode;
        }

        
        public void sethouseNameNumber(String theHouseNameNumber)
        {
            houseNameNumber = theHouseNameNumber;
        }

        
        public void setStreet(String theStreet)
        {
            street = theStreet;
        }

        
        public void setCounty(String theCounty)
        {
            county = theCounty;
        }

        
        public void setPostCode(String thePostCode)
        {
            postCode = thePostCode;
        }

        
        public String getHouseNameNumber()
        {
            return houseNameNumber;
        }

        
        public String getStreet()
        {
            return street;
        }

        
        public String getCounty()
        {
            return county;
        }

        
        public String getPostCode()
        {
            return postCode;
        }

        
        public override String ToString()
        {
            return (houseNameNumber + ", " + street +
                    ", " + county + ", " + postCode + ".");
        }
    }
}
}
