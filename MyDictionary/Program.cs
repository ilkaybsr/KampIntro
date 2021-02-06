using System;
using System.Collections.Generic;

namespace MyDictionary
{
     public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> patients = new MyDictionary<int, string>();

            patients.Add(20, "İlkay");
            patients.Add(15, "Batu");
            patients.Add(23, "Onur");
            patients.Add(56, "Tuğçe");
        }
    }
}
