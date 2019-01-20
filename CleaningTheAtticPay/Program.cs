using System;

namespace CleaningTheAtticPay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last Friday Trevon had \$29. Over the weekend he received some money
            //for cleaning the attic. He now has 41. How much money did he receive?

            int had = 29;
            int has = 41;
            int attic = has - had;
            Console.WriteLine("Trevon made $" + attic + " for cleaning the attic.");
        }
    }
}
