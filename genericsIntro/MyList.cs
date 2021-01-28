﻿using System;
using System.Collections.Generic;
using System.Text;

namespace genericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void add(T item)
        {
            T[] tempArray = items; 
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }
    }
}
