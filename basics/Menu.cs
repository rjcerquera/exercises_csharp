namespace basics
{
    public class Menu
    {
        public Menu(List<(string name, string element)> items)
        {
            int count = 1;
            foreach ((string name, string element) item in items)
            {
                Console.WriteLine($"{count}. Elija para ejecutar el ejercicio {item.name}");
                count++;
            }
        }
    }
}
