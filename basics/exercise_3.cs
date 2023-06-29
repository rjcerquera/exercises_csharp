namespace basics
{
    public class Exercise_3
    {
        public Exercise_3()
        {
            List<int> numbers = new List<int>();
            int baseNumber = 30;

            Console.WriteLine("program to check two given integers, and return true if one of them is 30 or if their sum is 30\n");
            Console.WriteLine("Ingrese el primer numero");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int number2 = int.Parse(Console.ReadLine());

            bool result = determine(baseNumber, number1, number2);
            Console.WriteLine($"El resultado es {result}");
        }

        public static bool determine(int baseNumber, int number1, int number2)
        {
            return number1 == baseNumber || number2 == baseNumber || (number1 + number2 == baseNumber);
        }
    }
}


