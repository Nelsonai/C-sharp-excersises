namespace Name
{
    public enum ImageSize{
        landscape,
        Portrait
    }
    class program{
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter width: ");
                var width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter height: ");
                var height = Convert.ToInt32(Console.ReadLine());

                var size = (width > height) ? ImageSize.landscape : ImageSize.Portrait;
                Console.WriteLine("Image size is: "+ size);
            }
            catch (System.Exception)
            {
                Console.WriteLine("INVALID INPUT, PLEASE ENTER A NUMBER.");
            }

        }
    }
}