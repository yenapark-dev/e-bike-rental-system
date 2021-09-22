using System;
namespace BikeManagement
{
    public interface IQueue
    {
        int CurrentQty { get; set; }

        int Capacity { get; }

        int Count { get; }
        
        bool IsEmpty();

        bool IsFull();

        void Enqueue(Bike item);

        Bike Dequeue();

        Bike Head();

        void Clear();

        Bike Search(Bike aBike);

        public void Print();
    }
}
