class AccountBalance
{
    static void Main()
    {
        string input = Console.ReadLine();
        decimal balance = 0;

        while (input!= "End")
        {
            decimal amount = decimal.Parse(input);
            
            if (amount > 0)
            {
                Console.WriteLine($"Increase: {amount:F2}");
                balance += amount;
            }
            else
            {
                Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
                balance += amount;
                
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Balance: {balance:F2}");
    }
}