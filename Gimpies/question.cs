using System;

namespace Gimpies
{
    public class question
    {
        // String input with question
        public static string InputString(String vraag)
        {
            //Console.Clear();
            Console.WriteLine(vraag);
            return Console.ReadLine();
        }

        // Input number with question
        public static int InputNum(String vraag)
        {

            String line = InputString(vraag);
            if (!string.IsNullOrEmpty(line))
            {
                int i = int.Parse(line);
                if (i > 0)
                {
                    return i;
                }
                Console.WriteLine("Nummer kan niet minder dan 0 zijn, Probeer het opnieuw.");
                Console.ReadKey();
                return InputNum(vraag);
            }
            else
            {
                int i = InputNum(vraag);
                if (i > 0)
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Nummer kan niet minder dan 0 zijn, Probeer het opnieuw.");
                    Console.ReadKey();
                    return InputNum(vraag);
                }
            }
        }

        // double input with question
        public static double Inputdob(String vraag)
        {
            String line = InputString(vraag);
            if (!string.IsNullOrEmpty(line))
            {
                double D = double.Parse(line);
                return D;
            }
            double DD = Inputdob(vraag);
            double inputdob = DD;
            return inputdob;
            
        }
    }
}