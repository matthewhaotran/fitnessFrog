namespace treehouse {
        class Program
    {
        static void Main()
        {
            // Prompt user for minutes exercised 
            System.Console.Write("Enter how many minutes you exercised: ");

            string entry = System.Console.ReadLine();

            // Add minutes exercised to total 
            // Display total minutes exercised to the screen 
            System.Console.WriteLine("You've exercised for " + entry + " minutes.");
            // Repeat until user quits    
        }
    }
}