namespace Excersise10
{
    public class StringReverse{
           /// <summary>
            /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
            /// Display the reversed name on the console.
            /// </summary>

        public static void StringMethod1()
        {
            Console.WriteLine("Enter your Name: ");
            var name = Console.ReadLine();

            var arr = name.ToCharArray();
            var length = arr.Length;

            var rev = "";
            for(var i = length-1; i >= 0; i--)
            {
                rev = rev+arr[i];    
            }
            Console.WriteLine(rev);
        }
        // Method 2
        public static void StringMethod2()
        {
            Console.WriteLine("Enter your Name: ");
            var read = Console.ReadLine();

            var arr = read.ToCharArray();

            var length = arr.Length;

            // Console.WriteLine($"Length is: {length}");

            for(var i = length-1; i>=0; i--)
            {
                Console.Write(arr[i]);
            }
        }
        // Method 3
        public static void StringMethod3WithInbuiltFunction(){
            Console.WriteLine("enter your Name: ");
            var name = Console.ReadLine();
            var arr = name.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new String(arr));
        }
    }
}