using System;

namespace MyDictionaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<string, int, double> isimler = new MyDictionaryList<string, int, double>();
            isimler.Add("Ertuğrul", 1, 05059864578);
            isimler.Add("Mehmet", 2, 05059867485);
            isimler.Add("Nisa", 3, 05056558971);
            isimler.Add("Onur", 4, 05053669875);
            isimler.Add("İsmail", 5, 05059665987);

            foreach (var item in isimler.Items1)
            {
                Console.WriteLine("User Name: " + item);
            }

            foreach (var item in isimler.Items2)
            {
                Console.WriteLine("User Number: " + item);
            }

            foreach (var item in isimler.Items3)
            {
                Console.WriteLine("User Phone Number" + item);
            }
        }
    }
}
