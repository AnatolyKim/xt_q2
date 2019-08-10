using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Task_3._3
{
    class DynamicArray<T>: IEnumerable
    {
        T[] array=new T[1];
        public int Length
        {
            get
            {
                int numberOfElements = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        numberOfElements++;
                    }
                    else break;
                }
                return numberOfElements;
            }
            private set { }
        }

        public int Capacity
        {
            get { return array.Length; }
            private set {}
        }

        public DynamicArray()
        {
           array= new T[8];
        }

        public DynamicArray(int x)
        {
            array = new T[x];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            IEnumerator ie = collection.GetEnumerator();
            int size = 0;
            foreach(T element in collection)
            {
                while (ie.MoveNext()) size++;
            }
            array = new T[size];
            foreach (T element in collection)
            {
                int i = 0;
                array[i] = element;
                i++;
            }

        }
        public void Add(T element)
        {
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i]=element;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                T[] extendedArray = new T[array.Length*2];
                array.CopyTo(extendedArray,0);
                extendedArray[array.Length] = element;
                array = new T[extendedArray.Length];
                extendedArray.CopyTo(array, 0);
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            bool flag = false;
            int size = 0;
            IEnumerator ie = collection.GetEnumerator();
            foreach (T element in collection)
            {
                while (ie.MoveNext()) size++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null&&size<array.Length-i)
                {
                    int j = i;
                    foreach (T element in collection)
                    {
                        array[j] = element;
                        j++;
                    }
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                T[] extendedArray = new T[array.Length+size];
                array.CopyTo(extendedArray, 0);
                int j = array.Length;
                foreach (T element in collection)
                {
                    extendedArray[j] = element;
                    j++;
                }
                array = new T[extendedArray.Length];
                extendedArray.CopyTo(array, 0);
            }
        }

        public bool Remove(T element)
        {
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    T[] tempArray = new T[array.Length];
                    for (int j = 0; j < i; j++)
                    {
                        tempArray[j] = array[j];
                    }
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        tempArray[j] = array[j + 1];
                    }
                    tempArray.CopyTo(array, 0);
                    flag=true;
                    break;
                }
            }
            return flag;
        }

        public bool Insert(T value,int position)
        {
            bool flag = false;
            if (position < array.Length)
            {
                if (array[position] != null)
                {
                    T[] tempArray = new T[array.Length * 2];
                    for (int j = 0; j < position; j++)
                    {
                        tempArray[j] = array[j];
                    }
                    tempArray[position] = value;
                    for (int j = position + 1; j < array.Length+1; j++)
                    {
                        tempArray[j] = array[j - 1];
                    }
                    array = new T[tempArray.Length];
                    tempArray.CopyTo(array, 0);
                }
                else array[position] = value;
                flag = true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Input position is out of range");
            }
            return flag;
        }

        // Как выполнить пункт пока не понимаю :(
        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index >= array.Length)
                {
                    throw new ArgumentOutOfRangeException("Input index is out of range");   
                }
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    throw new ArgumentOutOfRangeException("Input index is out of range");
                }
                array[index] = value;
            }
        }


    }
}
