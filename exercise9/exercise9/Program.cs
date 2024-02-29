namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 

            int starwidth = 0;
            int starheight = 0;
            int starwidth2 = 0;
            int starrow = starwidth2;

            // Prompts for * width and length

            Console.Write("Pick a width, any width ,':) ");
            int widthnumberpicked = int.Parse(Console.ReadLine());

            Console.Write("Pick a height, any height ,':) ");
            int heightnumberpicked = int.Parse(Console.ReadLine());

            // Prints * pattern

            for (starheight = 1; starheight < heightnumberpicked; starheight++)
            {
                Console.Write("*");

                for (starwidth = 1; starwidth < widthnumberpicked; starwidth++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            // Prompts for secondary * parttern width

            Console.Write("Pick width 2, any width ,':) ");
            int widthnumberpicked2 = int.Parse(Console.ReadLine());



            // Prints secondary * pattern

            for (starrow = 0; starrow < widthnumberpicked2; starrow++)
            {



                for (starwidth2 = 0; starwidth2 <= starrow; starwidth2++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();




            }


        }
    }
}