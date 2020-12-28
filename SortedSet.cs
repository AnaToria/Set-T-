using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace COMPE361
{
    public class SortedSet<T> : Set<T>
            where T : IComparable<T>
    {
        public SortedSet(IEnumerable<T> e)  //Parametrized constructor
                : base(e)
        {
            Accs.Sort();
        }
        public override bool Add(T item)
        {
            if (!Accs.Contains(item))
            {
                foreach (var elt in Accs)
                {
                    if (item.CompareTo(elt) < 0)
                    {
                        Accs.Insert(Accs.IndexOf(elt), item);
                        return true;
                    }
                }
            }

            return false;
        }

        public static SortedSet<T> operator +(SortedSet<T> lhs, SortedSet<T> rhs)
        {
            SortedSet<T> union = new SortedSet<T>(lhs);
            foreach (var item in rhs)
            {
                if (!lhs.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }
    }
}




/*using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace COMPE361
{
    public class SortedSet<T> : Set<T> 
            where T : IComparable<T> 
    {
        // Parametrized constructor
        public SortedSet(IEnumerable<T> e) 
                : base(e)
        {
            Data.Sort();
        }
    
        // Methods
        // Override Add
        public override bool Add(T item)
        {
            if (!Data.Contains(item))
            {
                foreach (var elt in Data)
                {
                    if (item.CompareTo(elt) < 0)
                    {
                        Data.Insert(Data.IndexOf(elt), item);
                        return true;
                    }
                }
            }

            return false;
        }

        // Union method for SortedSet
        public static SortedSet<T> operator +(SortedSet<T> lhs, SortedSet<T> rhs)
        {
            SortedSet<T> union = new SortedSet<T>(lhs);
            foreach (var item in rhs)
            {
                if (!lhs.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }

    }
}*/