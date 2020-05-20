using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 1;
            int count = 1000;

            //casting or explicit conversion
            number = (byte)count;

            //'var' automatically identified the data type.
            var num = "1234";
            //non-compatible conversion
            int new_num = Convert.ToInt32(num);

            //cannot store more than 232 that is max limit
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(new_num);
        }
    }
}
