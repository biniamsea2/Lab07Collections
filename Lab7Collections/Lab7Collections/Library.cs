using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Collections
{
    class Library<T>: IEnumerable
    {
        //user shouldn't care how its being added as long as its added
        private T[] storage = new T[5];
        private int currentIndex = 0;



        public void Add(T book)
        {
            if (currentIndex == storage.Length)
            {
                Array.Resize(ref storage, storage.Length * 2);
            }
            storage[currentIndex] = book;
            currentIndex++;
        }
    }
}
