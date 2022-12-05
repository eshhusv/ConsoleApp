namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите диаметр цииндра: ");
            double diameter = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            double height = double.Parse(Console.ReadLine());
            CylinderVolume volume = new CylinderVolume(diameter, height);
            Console.WriteLine($"Объём цилиндра равен {volume.getVolume()}");
        }
    }
}