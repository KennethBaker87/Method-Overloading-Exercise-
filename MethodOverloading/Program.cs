namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine(MethodOverload.Add(3, 5));
            Console.WriteLine(MethodOverload.Add(2.63m, 6.79m));
            Console.WriteLine(MethodOverload.Add(2, 5, true));
        }
    }
}
