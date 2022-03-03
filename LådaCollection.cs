using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class LådaCollection : ICollection<Låda>
    {
        private List<Låda> innerCol;
        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }
        public int Count { get { return innerCol.Count; } }

        public bool IsReadOnly { get { return false; } }

        public void Add(Låda item)
        {
            if(!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("En låda med dessa mått finns redan.");
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Låda item)
        {
            bool finns = false;

            foreach (Låda L in innerCol)
            {
                if(L.Equals(item))
                {
                    finns = true;
                }
            }
            return finns;
        }

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
            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

       

        public bool Remove(Låda item)
        {
            bool result = false;
            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda curLåda = innerCol[i];

                if(new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
    }
}
