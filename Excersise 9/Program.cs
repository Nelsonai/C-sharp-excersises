namespace Name
{
    class program{
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            /// display 8 on the console.
            /// </summary>    

            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            
            
            var max = Convert.ToInt32(numbers[0]);
            foreach (var i in numbers)
            {
                var max2 = Convert.ToInt32(i);
                if(max2 > max){
                    max = max2;
                }
            }
            Console.WriteLine("Max is: " + max);
            
        }
    }
}