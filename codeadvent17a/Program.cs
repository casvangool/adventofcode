using System;

namespace codeadvent17a
{
    class Program
    {
        static (int leftBorder, int rightBorder, int topBorder, int bottomBorder) grid = (95, 126, -97, -145);
        static void Main(string[] args)
        {
            (int leftBorder, int rightBorder, int topBorder, int bottomBorder) grid = (95, 126, -97, -145);
            int result = 0;
            for (int y = 0; y < 200; y++)
            {
                bool insidegrid = false;
                for (int x = 14; x < 16; x++)
                {
                    (int x, int y) position = (0, 0);
                    int progressionHorizontal = x;
                    int progressionVertical = y;
                    while (!BehindGrid(position.x, position.y))
                    {
                        position.x += progressionHorizontal;
                        position.y += progressionVertical;
                        if (InsideGrid(position.x, position.y))
                        {
                            Console.WriteLine(y);
                            result = y;
                            insidegrid = true;
                            break;
                        }
                        progressionHorizontal = progressionHorizontal > 0 ? progressionHorizontal - 1 : 0;
                        progressionVertical--;

                        if (progressionHorizontal == 0 && position.x < grid.leftBorder || insidegrid)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result);
            var height = 0;
            for (int i = 0; i < result; i++)
            {
                height += result - i;
            }
            Console.WriteLine(height);
            
        }

        static bool InsideGrid(int x, int y)
        {
            return grid.leftBorder < x && x < grid.rightBorder && grid.topBorder > y && grid.bottomBorder < y;
        }

        static bool BehindGrid(int x, int y)
        {
            return x > grid.rightBorder || y < grid.bottomBorder;
        }
    }
}
