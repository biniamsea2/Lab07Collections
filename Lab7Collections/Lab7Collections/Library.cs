using System;
using System.Collections;
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
            if (storage.Length == currentIndex)
            {
                Array.Resize(ref storage, storage.Length * 2);
            }
            storage[currentIndex] = book;
            currentIndex++;
        }



        public IEnumerable<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return storage[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        internal void Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
