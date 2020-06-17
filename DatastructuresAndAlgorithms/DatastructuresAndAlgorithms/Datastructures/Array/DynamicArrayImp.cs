using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructuresAndAlgorithms.Datastructures.Array
{

    interface IDynamicAarrayImp
    {
        void Add(int value);
        int Get(int index);

        void Set(int value, int index);

        bool Remove(int index);

        int RemoveAt(int index);

        bool Contanis(int value);

        bool IsEmpty();

        bool Length();


    }
    public class DynamicArrayImp : IDynamicAarrayImp
    {
        static int _capacity = 16;
        static int _length = 0;
        static int[] arr;
        public DynamicArrayImp():this(_capacity)
        {
            
        }

        public DynamicArrayImp(int capacity) 
        {
            _capacity=capacity;
            arr = new int[_capacity];
        }

        //Add the value to Array
        public void Add(int value)
        {
           if(_length<=_capacity)
            {
                arr[_length++] = value;
            }else
            {
                if (_capacity == 0)
                    _capacity = 1;
                _capacity = 2 * _capacity;
                int[] newArray = new int[_capacity];
                for (int i = 0; i < _length; i++)
                {
                    newArray[i] = arr[i];
                }
                arr = newArray;
            }
        }

        //Read the value by Index
        public int Get(int index)
        {
            if(index>=_length)
            {
                return -1;
            }
            return arr[index];
        }

        public bool Remove(int index)
        {
            if(_length<=index)
            {
                return false;
            }

            int[] newArr = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                if(i!=index)
                newArr[i] = arr[i];
            }
            arr = newArr;
            _capacity = --_length;
            return true;
        }
        public int RemoveAt(int index)
        {
            if (_length <= index)
            {
                return -1;
            }

            int[] newArr = new int[_length];
            int data =arr[index]
            for(int i = 0; i < _length; i++)
            {
                if (i != index)
                    newArr[i] = arr[i];
            }
            arr = newArr;
            _capacity = --_length;
            return data;
        }

        
        public bool Contanis(int value)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool Length()
        {
            throw new NotImplementedException();
        }

        public void Set(int value, int index)
        {
            throw new NotImplementedException();
        }
    }
}
