namespace basics
{
    public class Basics
    {
        public Basics()
        {
            List<(string, string)> exercises = new List<(string name, string element)> {
            ("hello world", "Hello"),
            ("ejercicio 2", "Exercise_2"),
            ("ejercicio 3", "Exercise_3"),
            };

            new Menu(exercises);

            int? option = int.Parse(Console.ReadLine());
            option--;

            Console.WriteLine(".................................................\n");

            switch (option)
            {
                case (int)subOptions.Hello:
                    new Hello();
                    break;
                case (int)subOptions.Exercise_2:
                    new Exercise_2();
                    break;
                case (int)subOptions.Exercise_3:
                    new Exercise_3();
                    break;
            }
        }
    }
}


enum subOptions
{
    Hello,
    Exercise_2,
    Exercise_3,
}