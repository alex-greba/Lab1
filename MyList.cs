using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLab1
{
    class MyList : IList<int>
    {
        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ListItem Root { get; set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new ListItem();
                Root.Value = value;
                Root.Next = null;
            }
            else
            {
                var current = Root;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                var newItem = new ListItem();
                current.Value = value;
                current.Next = newItem;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
