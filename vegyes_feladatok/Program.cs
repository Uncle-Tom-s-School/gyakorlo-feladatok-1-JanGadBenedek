namespace vegyes_feladatok
{
    internal class Program
    {
        static int feladat1() 
        {
            Console.WriteLine("Összes értékelés: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Pozitív értékelés: ");
            int p = int.Parse(Console.ReadLine());

        return n; 
        }

        static void feladat2() { }

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            Console.ReadKey();
            int p = feladat1();
            int n = feladat1();

            double szazalek = p / n * 100;
        }
    }
}
