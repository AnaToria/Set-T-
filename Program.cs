using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace COMPE361
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> set1 = new Set<int>();
            Console.WriteLine("set1 is empty : " + set1.IsEmpty);
            set1.Add(11);
            set1.Add(33);
            set1.Add(22);
            Console.WriteLine("set1 number of elemnts : " + set1.Count);
            Console.Write("set1 : ");
            foreach (var item in set1)
            {
                Console.Write(item+ "  ");
            }


            List<int> temp= new List<int>() { 34,0,87,58,100,13};
            Set<int> set2 = new Set<int>(temp);
            Console.Write("\nset2 : ");
            foreach (var item in set2)
            {
                Console.Write(item + "  ");
            }

            Console.Write("\nset1 + set2 : ");
            Set<int> setProd = set1 + set2;
            foreach (var item in setProd)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\nafter filtring : ");
            static bool filt(int n)
            {
                return (n >= 25) ? true : false;
            }
            setProd = setProd.Filter(filt);
            foreach (var item in setProd)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\nremoved 7 : " + setProd.Remove(7));
            Console.WriteLine("add 123 : " + setProd.Add(123));
            foreach (var item in setProd)
            {
                Console.Write(item + "  ");
            }

            SortedSet<int> sSet1 = new SortedSet<int>(setProd);
            Console.WriteLine("\nAfter sorting : ");
            foreach (var item in sSet1)
            {
                Console.Write(item + "  ");
            }

            List<int> temp2 = new List<int>() { 45, 32, 90, 100, 12, 1 };
            SortedSet<int> sSet2 = new SortedSet<int>(temp2);
            Console.WriteLine("\nanother sorted set : ");
            foreach (var item in sSet1)
            {
                Console.Write(item + "  ");
            }
            Console.Write("\nadd them up: ");
            Set<int> sSetProd = sSet1 + sSet2;
            foreach (var item in sSetProd)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\nremoved 32 : " + sSetProd.Remove(32));
            Console.WriteLine("\nremoved -1 : " + sSetProd.Remove(-1));
            Console.WriteLine("add 45 : " + sSetProd.Add(45));
            Console.WriteLine("add 62 : " + sSetProd.Add(62));
            foreach (var item in sSetProd)
            {
                Console.Write(item + "  ");
            }


            Console.ReadLine();
        }
    }
}