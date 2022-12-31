namespace Name
{
    class program{
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            /// </summary>
            
            for(var i = 1; i<=4; i++){
                Console.WriteLine("Enter a number between 1 and 10: ");
                var conv = Convert.ToInt32(Console.ReadLine());
                var random = new Random();
                var ran = Convert.ToInt32(random.Next(1, 10));
                if(conv!=ran){
                    var a = 0;
                    while(a<4){
                        Console.WriteLine("Guess a number between 1 and 10: ");
                        Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("you lost!");
                        break;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("you won");
                }
            }

            // MY INSTANCE;
            // var random = new Random();
            // var ran = Convert.ToInt32(random.Next(1, 10));
            // Console.WriteLine(ran);
        }
    }
}