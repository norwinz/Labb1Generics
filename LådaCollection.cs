using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class LådaCollection : ICollection<Låda>
    {
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        private List<Låda> innerCollection; //Private list to use within the LådaCollection-class
        public LådaCollection()
        {
            innerCollection = new List<Låda>();
        }       
        public int Count { get { return innerCollection.Count; } }
        public bool IsReadOnly { get { return false; } }
        public Låda this[int index]
        {
            get { return (Låda)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }
        //------------------------------------------------------------------------------------------------------
        public void Add(Låda item)
        {
            if(!Contains(item))
            {
                innerCollection.Add(item);
                Console.WriteLine("Den nya lådan är inlagd i listan.");
            }
            else
            {
                Console.WriteLine("En låda med dessa mått finns redan.");
            }
        }
        //------------------------------------------------------------------------------------------------------
        public void Clear()
        {
            innerCollection.Clear();
        }
        //------------------------------------------------------------------------------------------------------
        public bool Contains(Låda item)
        {
            bool boxAlreadyExist = false;

            foreach (Låda L in innerCollection)
            {
                if(L.Equals(item))
                {
                    boxAlreadyExist = true;
                }
            }
            return boxAlreadyExist;
        }
        //------------------------------------------------------------------------------------------------------
        public void CopyTo(Låda[] array, int arrayIndex)
        {
           if(array == null)
            {
                throw new ArgumentException("Array kan inte var null");
            }
           if(arrayIndex <0 )
            {
                throw new ArgumentOutOfRangeException("Index kan inte vara mindre än 0");
            }
           if(Count > array.Length - arrayIndex +1)
            {
                throw new ArgumentException("Index finns ej");
            }
            for (int i = 0; i < innerCollection.Count; i++)
            {
                array[i + arrayIndex] = innerCollection[i];
            }
        }
        //------------------------------------------------------------------------------------------------------
        public bool Remove(Låda item)
        {
            bool result = false;
            for (int i = 0; i < innerCollection.Count; i++)
            {
                Låda curLåda = innerCollection[i];

                if(new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    Console.WriteLine("Lådan är borttagen.");
                    break;
                }
            }
            Console.WriteLine("Låda med de måtten finns ej.");
            return result;
        }
        //------------------------------------------------------------------------------------------------------
        
    }
}
