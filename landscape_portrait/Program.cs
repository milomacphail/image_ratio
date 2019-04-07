using System;

namespace landscape_portrait
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an image height.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an image width.");
            int width = int.Parse(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Portrait");
            } else if (width > height) {
                Console.WriteLine("Landscape");
            } else if (width == height)
            {
                Console.WriteLine("Square");
            }
        }
    }
}
