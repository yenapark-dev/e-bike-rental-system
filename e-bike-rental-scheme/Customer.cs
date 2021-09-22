using System;
namespace BikeManagement
{
    public class Customer: IComparable
    {
        private string lastname;
        private string firstname;
        private int mobile;

        public string FirstName
        {
            get { return firstname; }
        }

        public string LastName
        {
            get { return lastname; }
        }

        public int Mobile
        {
            get { return mobile; }
        }

        public Customer(string lastName, string firstName, int mobileNumber)
        {
            this.lastname = lastName;
            this.firstname = firstName;
            this.mobile = mobileNumber;
        }

        public Customer()
        {

        }


        private Bike borrowingBike = new Bike("none");

        public Bike GetBorrowingBike
        {
            get
            {
                if (borrowingBike != null)
                {
                    return borrowingBike;
                }
                else
                {
                    return null;
                }
            }
        }

        public void addBike(Bike aBike)
        {
            borrowingBike = aBike;
        }

        public void deleteBike()
        {
            borrowingBike = null;
        }

        public int CompareTo(Object obj)
        {
            Customer another = (Customer)obj;
            if (this.lastname.CompareTo(another.LastName) < 0)
                return -1;
            else
                if (this.lastname.CompareTo(another.LastName) == 0)
                return this.firstname.CompareTo(another.FirstName);
            else
                return 1;
        }


        public override string ToString()
        {
            if (borrowingBike != null)
            {
                return (firstname + " " + lastname + " " + mobile.ToString() + " " + "Bike " + borrowingBike.BikeID + "\n");
            }
            else
                return (firstname + " " + lastname + " " + mobile.ToString() + " " + "Bike none" + "\n");
        }
    }
}
