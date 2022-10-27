using System;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");

            // variable:

            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'a';
            //string firstName = "Mosh";
            //bool isworking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isworking);

            //Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);

            // conversion:

            // implicit

            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            // explicit
            //int i = 1;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            // non-compatable

            //int i = Convert.ToInt32(number);
            

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("the number could not be converted to byte");
            }

        }
    }
}
