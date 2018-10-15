using System;

class Program
{
    public static uint Input()
    {
        uint a;

        while (!uint.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Неверный ввод, повторите попытку: ");
        }

        return a;
    }

    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("fsada");
            Console.WriteLine(double.Epsilon);


        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }

}
/*String.Format("{0:0.0}", 0.0);          "0.0"
String.Format("{0:0.#}", 0.0);            "0"
String.Format("{0:#.0}", 0.0);            ".0"
String.Format("{0:#.#}", 0.0);            ""
*/
