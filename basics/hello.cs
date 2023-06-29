namespace basics
{
    public class Hello
    {
        public Hello()
        {
            Console.WriteLine("Ingrese dos numero para multplicar");
            string? numbers = Convert.ToString(Console.ReadLine());
            if (numbers?.Split(" ").Length == 2)
            {
                string[] listNumbers = numbers.Split(" ");
                Console.WriteLine("La multiplicacion es {0}", int.Parse(listNumbers[0]) * int.Parse(listNumbers[1]));
            }
        }
    }
}


