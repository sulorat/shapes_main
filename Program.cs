namespace shapes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape shape = new shape();
            triangle triangle = new triangle();
            circle circle = new circle();
            square square = new square();
            rectangle rectangle = new rectangle();
            piramid piramid = new piramid();
            try
            {
                while (true)
                {

                    Console.Clear();
                    Console.WriteLine("Q - circle\nW - square\nE - rectangle\nR - triangle\nT - pyramid");
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.Q:
                            {
                                Console.Clear();
                                circle.shape_found();
                                Console.WriteLine("Press any button to continue");
                                Console.ReadKey();
                                break;
                            }
                        case ConsoleKey.W:
                            {
                                Console.Clear();
                                square.shape_found();
                                Console.WriteLine("Press any button to continue");
                                Console.ReadKey();
                                break;
                            }
                        case ConsoleKey.E:
                            {
                                Console.Clear();
                                rectangle.shape_found();
                                Console.WriteLine("Press any button to continue");
                                Console.ReadKey();
                                break;
                            }
                        case ConsoleKey.R:
                            {
                                Console.Clear();
                                {
                                    triangle.shape_found();
                                    Console.WriteLine("Press any button to continue");
                                    Console.ReadKey();
                                }
                                break;
                            }
                        case ConsoleKey.T:
                            {
                                Console.Clear();
                                {
                                    Console.WriteLine("Which type of piramida?\nA - square piramida\nS - Circle piramida\nD - triangle piramida");
                                    ConsoleKey need_key = Console.ReadKey().Key;
                                    Console.Clear();
                                    switch (need_key)
                                    {
                                        case ConsoleKey.A:

                                            {
                                                square.piramid_found();
                                                Console.WriteLine("Press any button to continue");
                                                Console.ReadKey();
                                                break;
                                            }
                                        case ConsoleKey.S:
                                            {
                                                piramid.shape_found();
                                                Console.WriteLine("Press any button to continue");
                                                Console.ReadKey();
                                                break;
                                            }
                                        case ConsoleKey.D:
                                            {
                                                triangle.piramid_found();
                                                Console.WriteLine("Press any button to continue");
                                                Console.ReadKey();
                                                break;
                                            }
                                    }
                                    break;
                                }
                            }
                    }
                }
            }
            catch
            {
                Console.WriteLine("error");
                return;
            }

        }
    }
}