using System;
using DbClassLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DbClass dbClass = new DbClass();
            Console.WriteLine(dbClass.GetConnString());
        }
    }
}
