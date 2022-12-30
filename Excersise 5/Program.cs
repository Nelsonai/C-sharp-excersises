namespace Name
{
    class program{
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            /// Display the result on the console.
            /// </summary>   

            // First solution
            for(var i=1; i<100; i++){
                if(i%3==0){
                    Console.WriteLine(i);
                }
            }
            // Second solution
            var n = 1;
            while(n<100){
                if(n%3==0){
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }
}