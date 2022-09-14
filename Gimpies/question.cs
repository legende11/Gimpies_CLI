using System;

namespace Gimpies
{
    public class question
    {
        
        // recursion ftw. 
        // String input with question
        public static string InputString(String vraag)
        {
            Console.WriteLine(vraag);
            return Console.ReadLine();
        }

        // Input number with question
        public static int InputNum(String vraag)
        {
            try
            {
                String line = InputString(vraag);
                int number = Convert.ToInt32(line);
                return number > 0 ? number : InputNum(vraag);
            }
            catch (Exception)
            {
                Console.WriteLine("Input ongeldig.");
                return InputNum(vraag);
            }

        }
        

        // double input with question
        public static double Inputdob(String vraag)
        {
            try
            {
                String line = InputString(vraag);
                double dob = Convert.ToDouble(line);
                return dob;
            }
            catch (Exception)
            {
                Console.WriteLine("Input ongeldig.");
                return Inputdob(vraag);
            }

        }
    }
}