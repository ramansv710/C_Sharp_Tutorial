namespace C_Sharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var starPatternsProgram = new StarPatternsProgram();
            StarPatternsProgram.RightTrianglePattern();
            StarPatternsProgram.MirroredRightAngleTrianglePattern();
            StarPatternsProgram.DownwardTrianglePattern();
            StarPatternsProgram.DownwardMirroredRightTrianglePattern();
            StarPatternsProgram.HollowRightTrianglePattern();
            StarPatternsProgram.InvertedPyramidOfNumbers();
            starPatternsProgram.HalfPyramidOfNumbers();
        }
    }
}