using System;

namespace vn_mode_csharp_dz04
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = 52;
            int countPictureInLine = 3;
            int countRows;
            int leftPictures;

            countRows = allPictures / countPictureInLine;
            leftPictures = allPictures % countPictureInLine;

            Console.WriteLine($"Полностью заполненных рядов будет {countRows}, а {leftPictures} картин(ка/нок) будет сверх меры.");
        }
    }
}
