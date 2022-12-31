namespace Name
{
    class program{
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program which takes a single argument from the console, computes the factorial and prints the 
            /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            /// and display it as 5! = 120.
            /// </summary>

            // FIRST SOLUTION
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if(number <= 0){
                Console.WriteLine("Cant compute Factorail");
            }
            else
            {
                var factorial = 1;
                for(var counterVar = 1; counterVar<=number; counterVar ++){
                    factorial*=counterVar;
                }
                Console.WriteLine("{0}! = {1} ", number, factorial);
            } 

            // SECOND SOLUTION
            Console.WriteLine("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input <= 0){
                Console.WriteLine("Cant compute Factorial");
            }
            else
            {   
                var factorial = 1;
                for(var i= 1; i<=input; i++){
                    factorial = factorial*i;
                }
                Console.WriteLine("Factorial of number is: " + factorial);
            } 
        }
    }
}