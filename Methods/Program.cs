internal class Program
{
    static void Main(string[] args)
    {
        int result = Add(5, 6);
        Console.WriteLine(result);
    }
    static int Add(int number1,  int number2)
    {
        int result = number1 + number2;
        return result;
        
    }
}