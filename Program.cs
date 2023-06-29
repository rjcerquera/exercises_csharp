namespace program;
using basics;

class program
{
    static void Main()
    {
        List<(string, string)> exercises = new List<(string name, string element)> {
            ("basico", "Hello"),
        };

        new Menu(exercises);

        int? option = int.Parse(Console.ReadLine());
        option--;
        Console.WriteLine(".................................................\n");

        switch (option)
        {
            case (int)options.Basics:
                new Basics();
                break;
        }

    }
}

enum options
{
    Basics
}