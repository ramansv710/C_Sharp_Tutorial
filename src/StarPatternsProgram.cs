namespace C_Sharp_Tutorial
{
    public class StarPatternsProgram
    {
        public static void RightTrianglePattern()
        {
            //int rows = 5;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}
        }

        public static void MirroredRightAngleTrianglePattern()
        {
            Console.Write("Enter number of Rows :");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                //rows - i  //let rows = 5
                /* first row (5-1) = 4 spaces
                 * second row (5-2) = 3 spaces
                 * third row (5-3) = 2 spaces
                 * and so on
                */
                
                //calculate blank space for each row one by one
                for (int j = rows - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                
                //calculate no. of stars in each row
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        public static void DownwardTrianglePattern()
        {
            
            Console.Write($"Enter number of Rows : ");
            int rows = 5; Convert.ToInt32(Console.Read());
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < rows - i; k++)
                {
                    if (k == (rows - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public static void DownwardMirroredRightTrianglePattern()
        {
        }

        public static void HollowRightTrianglePattern()
        {
        }

        public static void InvertedPyramidOfNumbers()
        {
        }

        public void HalfPyramidOfNumbers()
        {
        }
    }
}
