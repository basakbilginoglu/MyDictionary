using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Mesut Özil");
            myDictionary.Add(2, "Ayşe Geçer");
            myDictionary.Add(3, "Aslı Tandoğan");

            myDictionary.ToList();
            Console.WriteLine(myDictionary.Count()); 
        }
    }
}