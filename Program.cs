internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Введите первое число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Введите второе число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        
        
        if (firstNumber<secondNumber)
        {
            System.Console.WriteLine($"Число {secondNumber} больше чем {firstNumber}");
        }
        else if (firstNumber>secondNumber)
        {
            System.Console.WriteLine($"Число {firstNumber} больше чем {secondNumber}");
        }
    }
}