using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> citys = new MyList<string>();
            citys.Add("Istanbul");
            citys.Add("Ankara");
            citys.Add("Izmir");
            citys.Add("Kocaeli");
            citys.Add("Kastamonu");


            //list i yazdıran method 
            citys.Write();

            Console.ReadLine();
        }
    }
}
