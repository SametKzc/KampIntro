using MyDictionary;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
        myDictionary.Add(1, "Apple");
        myDictionary.Add(2, "Samsung");
        myDictionary.Add(3, "Xiaomi");
        myDictionary.printDictionary();
    }
}