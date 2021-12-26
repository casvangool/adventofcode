using System;

namespace codeadvent17b
{
    class Program
    {
        static (int leftBorder, int rightBorder, int topBorder, int bottomBorder) grid = (95, 126, -97, -145);
        static void Main(string[] args)
        {
            (int leftBorder, int rightBorder, int topBorder, int bottomBorder) grid = (95, 126, -97, -145);
            int result = 0;
            for (int y = -145; y < 200; y++)
            {
                for (int x = 0; x < 127; x++)
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
                            result += 1;
                            break;
                        }
                        progressionHorizontal = progressionHorizontal > 0 ? progressionHorizontal - 1 : 0;
                        progressionVertical--;

                        if (progressionHorizontal == 0 && position.x < grid.leftBorder)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result);
            
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
