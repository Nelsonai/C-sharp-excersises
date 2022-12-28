namespace Name
{
    class program{
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>    
            Console.WriteLine("This program ouputs the bigger number");
            Console.WriteLine("Enter a number: ");
            var userInput1 = Console.ReadLine();
            var convert1 = Convert.ToInt32(userInput1);
            Console.WriteLine("Enter another number: ");
            var userInput2 = Console.ReadLine();
            var convert2 = Convert.ToInt32(userInput2);
            if(convert1 > convert2){
                Console.WriteLine("The bigger number is: " + (convert1));
            }
            else if(convert2 > convert1){
                Console.WriteLine("The bigger number is: " + (convert2));
            }
            else
            {
                Console.WriteLine("Not a VALID input");
            } 

            Console.WriteLine("you can also do it this way below");

        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        }
    }
}