using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Labb1Generics
{
    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection lådor;
        private int curIndex;
        private Låda curLåda;
        
        public LådaEnumerator(LådaCollection låda)
        {
            lådor = låda;
            curIndex = -1;
            curLåda = default(Låda);
        }
        //------------------------------------------------------------------------------------------------------
        public Låda Current { get { return curLåda; } }
        object IEnumerator.Current { get { return Current; } }     
        public int Count { get { return lådor.Count; } }
        //------------------------------------------------------------------------------------------------------
        public bool MoveNext()
        {
            if(++curIndex >= lådor.Count)
            {
                return false;
            }
            else
            {
                curLåda = lådor[curIndex];
            }
            return true;
           
        }
        //------------------------------------------------------------------------------------------------------
        public void Reset()
        {
            curIndex = -1;
        }
        //------------------------------------------------------------------------------------------------------
        public void Dispose()
        {
            
        }
    }
}
