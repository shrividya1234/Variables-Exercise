namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaration and initializing the variables
            String name = "Shrividya";
            int age = 20;
            char middlename = 'G';
            bool isOver18 = true;
            double currentTemp = 80.2;
            decimal currentPrice = 10.55m;
            
            //Interpolate these variables in a Console.Writeline();
            Console.WriteLine($"My name is : {name}");     
            Console.WriteLine($"My age is : {age}"); 
            Console.WriteLine($"My Middlename is : {middlename}");  
            Console.WriteLine($"My Over18 is : {isOver18}"); 
            Console.WriteLine($"My CurrentPrice is :{currentPrice}");
            //Console.WriteLine("Hello, World!");
        }
    }
}
