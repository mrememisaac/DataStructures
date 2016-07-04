using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ArrayList<T> : System.Collections.Generic.IList<T>
    {
        T[] _items;

        public ArrayList()
            : this(0)
        {

        }

        public ArrayList(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException("length");
            }
            _items = new T[length];
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            //0. Check to ensure that the index is valid
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            //check if we need to grow the array
            if (Count == _items.Length)
            {
                //grow the array
                GrowArray();
            }

            //1. Shift items at that position right
            Array.Copy(_items, index, _items, index + 1, Count - index);

            //2. Insert the item at that slot
            _items[index] = item;
            Count++;
        }

        private void GrowArray()
        {
            int newLength = _items.Length == 0 ? 16 : _items.Length * 2;
            T[] newArray = new T[newLength];
            _items.CopyTo(newArray, 0);
            _items = newArray;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            
            //overwrite that spot
            Array.Copy(_items, index + 1, _items, index, Count - (index+1)); //shift left
            
            Count--; //decrease 
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                _items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (item == null)
            {
                return;
            }
            if (Count == _items.Length)
            {
                GrowArray();
            }
            _items[Count] = item;
            Count++;
        }

        public void Clear()
        {
            _items = new T[0];
            Count = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            //_items.CopyTo(array, arrayIndex); We are not using this because we dont want to copy empty slots
            Array.Copy(_items, 0, array, arrayIndex, Count);
        }

        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index > -1)
            {
                RemoveAt(index);
                Count--;
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //we cant call _items.GetEnumerator() because it will return all the slots including the empty ones
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
