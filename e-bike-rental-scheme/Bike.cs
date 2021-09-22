using System;
namespace BikeManagement
{
    public class Bike : IComparable
    {
        private string bikeID;

        public Bike(string bikeID)
        {
            this.bikeID = bikeID;
        }

        public string BikeID
        {
            get { return bikeID; }
        }

        public int CompareTo(Object obj)
        {
            Bike another = (Bike)obj;

            if (this.bikeID.CompareTo(another.BikeID) < 0)
                return -1;
            else
                  if (this.bikeID.CompareTo(another.BikeID) == 0)
            {
                return 0;
            }

            else
            {
                return 1;
            }

        }

        public Bike()
        {

        }

    }
}
