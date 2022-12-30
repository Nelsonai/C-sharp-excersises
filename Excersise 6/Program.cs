namespace Name
{
    class program{
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            /// </summary>

            try
            {
                var sum = 0;
	
	            while (true){
	                Console.WriteLine("Enter a number: ");
	                var input = Console.ReadLine();
	                
	                if(input == "OK" || input=="ok" || input == "exit" || input=="Exit"){
	                    break;
	                }
	                sum+=Convert.ToInt32(input);
	            }
	            Console.WriteLine("sum is: " + sum);
            }
            catch (System.Exception)
            { 
                Console.WriteLine("Invalid input");
            }
        }
    }
}