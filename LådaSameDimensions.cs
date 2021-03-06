using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1Generics
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals(Låda L1, Låda L2)
        {
            if(L1.höjd == L2.höjd && L1.längd == L2.längd && L1.bredd == L2.bredd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            int hCode = obj.höjd ^ obj.längd ^ obj.bredd;
            return hCode.GetHashCode();
        }
    }
}
