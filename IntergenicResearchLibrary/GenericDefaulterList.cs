using System;
using System.Collections.Generic;
namespace IntergenicResearchLibrary
{
    public class GenericDefaulterList<T> where T : IDefaulter
    {
        private T[] studentDefaulters;
        private int numElements;
        private const int DEFAULTSIZE = 6;
        public GenericDefaulterList()
        {
            studentDefaulters = new T[DEFAULTSIZE];
            numElements = 0;
        }

        public GenericDefaulterList(int size) 
        {
            studentDefaulters = new T[size];
            numElements = 0;
        }

        public void Add(T item)
        {
            if(numElements < studentDefaulters.Length)
            {
                studentDefaulters[numElements] = item;
                numElements++;
            }else{
                throw new System.Exception("studentDefaulters collection is full...");
            }
        }

    

        public void GetDefaulter()
        {
            if(numElements < 0)
            {
                throw new System.Exception("studentDefaulters collection is empty...");
                
            }
            foreach (var item in studentDefaulters)
            {
                Console.WriteLine(item);
            }
        }
    }
}