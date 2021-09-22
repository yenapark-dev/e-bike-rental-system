using System;
namespace BikeManagement
{
    public interface IBST
    {
        bool IsEmpty();

        void Insert(IComparable item);

        void Delete(IComparable item);

        Customer Search(IComparable item);

        void InOrderTraverse();

        void Clear();

    }
}
