using System;
using System.Collections.Generic;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHashSet = new HashSet<string>();

            bool didItAddTheValue = false;

            didItAddTheValue = myHashSet.Add("first string");


            myHashSet.Add("First string");
            myHashSet.Add("Second string");
            myHashSet.Add("Second string");

                foreach (var item in myHashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("the set has this many items");
        }
    }
}

public class MyClass
{

}
