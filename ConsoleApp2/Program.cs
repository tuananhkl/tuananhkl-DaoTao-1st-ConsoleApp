using System.Text;

namespace ConsoleApp2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Tên tôi là: {name}");
        }
    }
}