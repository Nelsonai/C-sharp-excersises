namespace Name
{
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
    class program{
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter width: ");
                var width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter height: ");
                var height = Convert.ToInt32(Console.ReadLine());

                if(width > height){
                    Console.WriteLine("Image is a landscape");
                }
                else if(height > width) {
                    Console.WriteLine("Image is a Portrait");
                }
                else{
                    Console.WriteLine("INVALID INPUT");
                }   
            }
            catch (System.Exception)
            {
                Console.WriteLine("INVALID INPUT, PLEASE ENTER A NUMBER.");
            }
        }
    }
}