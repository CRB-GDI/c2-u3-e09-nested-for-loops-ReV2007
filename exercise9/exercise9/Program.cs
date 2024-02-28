namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int starwidth = 0;
            int starheight = 0;
            

            Console.Write("Pick a width, any width ,':) ");
            int widthnumberpicked = int.Parse(Console.ReadLine());

            Console.Write("Pick a height, any height ,':) ");
            int heightnumberpicked = int.Parse(Console.ReadLine());

          

            for (starheight = 0; starheight <= heightnumberpicked; starheight++) 
            {
                Console.Write( "*" );

                for (starwidth = 0; starwidth <= widthnumberpicked; starwidth++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
          
        }
    }
}