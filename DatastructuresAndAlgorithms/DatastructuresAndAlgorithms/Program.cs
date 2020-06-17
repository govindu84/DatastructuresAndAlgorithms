using System;
using DatastructuresAndAlgorithms.Datastructures.Array;

namespace DatastructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            IDynamicAarrayImp dynamicArrayImp = new DynamicArrayImp();
            dynamicArrayImp.Add(5);
            Console.WriteLine("Hello World!" + dynamicArrayImp.Get(0));
            dynamicArrayImp.Delete(0);
            dynamicArrayImp.Add(6);
            Console.WriteLine("Hello World!" + dynamicArrayImp.Get(0));
            Console.ReadLine();
        }
    }
}
