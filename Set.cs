using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace COMPE361
{
    public class Set<T> : IEnumerable<T>
    {
        protected List<T> Accs;
        public delegate bool F<T>(T elt);

        //properties of Set<T>
        public int Count
        {
            get
            {
                return Accs.Count();
            }
        }
        public bool IsEmpty
        {
            get
            {
                return !Accs.Any();
            }
        }
        public Set()    //Default constructor
        {
            Accs = new List<T>();
        }
        public Set(IEnumerable<T> e)    //Parametrized constructor
        {
            Accs = new List<T>();
            foreach (var element in e)   //Initialization
            {
                if (!Accs.Contains(element))
                {
                    Accs.Add(element);
                }
            }
        }
        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)    // overloading "+"
        {
            Set<T> union = new Set<T>(lhs);
            foreach (var Accs in rhs)
            {
                if (!union.Contains(Accs))
                {
                    union.Accs.Add(Accs);
                }
            }
            return union;
        }
        public virtual bool Add(T item)
        {
            if (!Accs.Contains(item))
            {
                Accs.Add(item);
                return true;
            }
            return false;
        }
        public bool Remove(T item)
        {
            if (Accs.Contains(item))
            {
                Accs.Remove(item);
                return true;
            }

            return false;
        }
        public bool Contains(T item) => Accs.Contains(item); //Checking if item is in set
        public Set<T> Filter(F<T> filterFunction)
        {
            Set<T> filtered = new Set<T>();
            foreach (var elt in Accs)
            {
                if (filterFunction(elt))
                {
                    filtered.Accs.Add(elt);
                }
            }
            return filtered;
        }
        public IEnumerator<T> GetEnumerator()   //IEnumerable interface
        {
            foreach (var elt in Accs)
            {
                yield return elt;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
    // Declaring delegate outside the class
    public delegate bool F<T>(T elt);

    public class Set<T> : IEnumerable<T>
    {
        // Properties
        protected List<T> Data;

        public int Count
        {
            get
            {
                return Data.Count();
            }
        }

        public bool IsEmpty
        {
            get
            {
                return !Data.Any();
            }
        }


        // Methods
        // Default constructor
        public Set()
        {
            Data = new List<T>();
        }

        // Parametrized constructor
        public Set(IEnumerable<T> e)
        {
            Data = new List<T>();
            // Initializing
            foreach(var element in e)
            {
                // Checking whether element is already in my Set 
                if (!Data.Contains(element))
                {
                    Data.Add(element);
                }
            }
        }

        // Set union by overloading +
        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)
        {
            Set<T> union = new Set<T>(lhs);

            // Adding different elements 
            foreach (var data in rhs)
            {
                if(!union.Contains(data))
                {
                    union.Data.Add(data);
                }
            }

            return union;
        }

        // Add item to the set
        public virtual bool Add(T item)
        {
            if (!Data.Contains(item))
            {
                Data.Add(item);
                return true;
            }

            return false;
        }

        // Remove item from the set
        public bool Remove(T item)
        {
            if (Data.Contains(item))
            {
                Data.Remove(item);
                return true;
            }

            return false;
        }

        // Check if item is in the set
        public bool Contains(T item) => Data.Contains(item);
     
        // Filter
        public Set<T> Filter(F<T> filterFunction)
        {
            Set<T> filteredSet = new Set<T>();

            foreach (var elt in Data)
            {
                if (filterFunction(elt))
                {
                    filteredSet.Data.Add(elt);
                }
            }

            return filteredSet;
        }


        // Implementing IEnumerable interface
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var elt in Data)
            {
                yield return elt;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}*/
