namespace Name
{
    class program{
        static void Main(string[] args)
        {
           /// <summary>
            /// Wri te a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>  
            Console.Write("Enter a number between 1 and 10: ");
            var userInput = Console.ReadLine();
            var convert1 = Convert.ToInt32(userInput);
            if(convert1 >= 1 && convert1 <= 10){
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }   
    }
}