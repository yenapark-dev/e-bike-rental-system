using System;
namespace BikeManagement
{
    public class ListNode
    {
        private Bike data;
        private ListNode next;

        public ListNode(Bike obj)
        {
            data = obj;
            next = null;
        }

        public Bike Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public ListNode Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

    }  // Enf of ListNode
}
