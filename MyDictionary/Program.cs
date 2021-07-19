using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(1, "Ulaş");
            isimler.Add(2, "Engin");
            isimler.Add(3, "Murat");
            isimler.Add(4, "Merve");
            
        }
    }
}
