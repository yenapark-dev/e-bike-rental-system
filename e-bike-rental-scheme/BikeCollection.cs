using System;
namespace BikeManagement
{
	public class BikeCollection : IQueue
	{
        const int TOTAL_BIKE = 50;
        private int currentQty = TOTAL_BIKE;
        private int capacity = Int32.MaxValue;
        private int count = 0;
        private ListNode tail = null;
        private string id = "0";

        public int CurrentQty
        {
            get
            {
                return currentQty;
            }
            set
            {
                currentQty = value;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }


        public bool IsFull()
        {
            return count == capacity;
        }

        public void Enqueue(Bike item)
        {
            // Check the pre-condition
            if (!IsFull())
            {
                ListNode aNode = new ListNode(item);
                // Special case: the queue is empty
                if (count == 0) 
                {
                    tail = aNode;
                    tail.Next = tail;
                }
                // General case
                else
                {
                    aNode.Next = tail.Next;
                    tail.Next = aNode;
                    tail = aNode;
                }
                count++;
            }
        }

        public Bike Dequeue()
        {
            // Check the pre-condition
            if (!IsEmpty())
            {
                Bike data;
                // Special case: the queue has only 1 item
                if (count == 1) 
                {
                    data = tail.Data;
                    tail = null;
                }
                // General case
                else
                {
                    data = tail.Next.Data;
                    tail.Next = tail.Next.Next;
                }
                count--;
                return data;
            }
            else
                return null;
        }

        public Bike Head()
        {
            // Check the pre-condition
            if (!IsEmpty())
            {
                Bike data = tail.Next.Data;
                return data;
            }
            else
                return null;
        }

        public void Clear()
        {
            tail = null;
            count = 0;
        }

        public Bike Search(Bike aBike)
        {
            if (tail != null)
            {
                // Initialize current
                ListNode current = tail;

                while (count > 0)
                {
                    if (id == current.Data.BikeID)
                    {
                        break;
                    }
                    else
                    {
                        if (current.Data.BikeID.Equals(aBike.BikeID))
                            return current.Data; // Data found 
                    }
                    id = current.Data.BikeID;
                    current = current.Next;
                    count--;
                }
                return null; // Data not found
            }
            else
                return null;
        }


        public void Print()
        {
            // Initialize current
            ListNode current = tail; 

            while (current != null)
            {
                if (id == current.Data.BikeID)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(current.Data.BikeID);
                    id = current.Data.BikeID;
                }
                current = current.Next;
            }
        }
    }
}
