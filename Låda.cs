using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class Låda : IEquatable<Låda>
    {

        public Låda(int h, int l, int b)
        {
            this.höjd = h;
            this.längd = l;
            this.bredd = b;
        }
        public int höjd { get; set; }
        public int längd { get; set; }
        public int bredd { get; set; }

        public int Volym()
        {
            int volym = höjd * bredd * längd;

            return volym;
        }
        public bool Equals(Låda other)
        {
            if (new LådaSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
