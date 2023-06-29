namespace basics
{
    public class Exercise_2
    {
        public Exercise_2()
        {
            List<int> numbers = new List<int>();
            int baseNumber = 51;

            Console.WriteLine("Program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference\n");
            Console.WriteLine("Ingrese el primer numero");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Ingrese el segundo numero");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Ingrese el tercer numero");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));

            foreach (int number in numbers)
            {
                determine(baseNumber, number);
            }
        }

        public static void determine(int baseNumber, int number)
        {
            int difference = Math.Abs(number - baseNumber);
            if (number > baseNumber)
            {
                difference = difference * 3;
            }

            Console.WriteLine($"El resultado Es {difference}");

        }
    }
}


