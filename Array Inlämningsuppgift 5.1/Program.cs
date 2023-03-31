using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Meningar = { "Hej1 Hej1 Hej1 Hej1 Hej1", "Hej2 Hej2 Hej2", "Hej3 Hej3 Hej3 Hej3" }; 
            
            for(int i = 0; i < Meningar.Length; i++)
            {
                Console.WriteLine(Meningar[i] + "\n");
            }

        }
    }
}
