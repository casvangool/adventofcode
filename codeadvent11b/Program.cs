using System;

namespace codeavent11b
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = Input.Map();
            var steps = 0;
            for (int step = 1; step < 100000; step++)
            {
                if (AllZero(map))
                {

                }
                IncreaseAllBy1(map);
                while (GetBling(map))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int b = 0; b < 10; b++)
                        {
                            if (map[i, b] > 9)
                            {
                                Bling(map, i, b);
                            }
                        }
                    }
                }
            }
        }

        private static bool GetBling(int[,] map) {
            for(int i = 0; i < 10; i++)
            {
                for(int b = 0; b < 10; b++)
                {
                    if (map[i, b] > 9)
                        return true;
                }
            }
            return false;
        }

        private static void IncreaseAllBy1(int[,] map)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int b = 0; b < 10; b++)
                {
                    map[i, b] += 1;
                }
            }
        }

        private static bool AllZero(int[,] map)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int b = 0; b < 10; b++)
                {
                    if (map[i, b] != 0)
                        return false;
                }
            }

            return true;
        }

        private static void Bling(int[,] map, int i, int b)
        {
            if (i != 0 && b != 0 && map[i - 1, b - 1] != 0)
                map[i - 1, b - 1] += 1;

            if (i != 0 && map[i - 1, b] != 0)
                map[i - 1, b] += 1;

            if (i != 0 && b != 9 && map[i - 1, b + 1] != 0)
                map[i - 1, b + 1] += 1;

            if (b != 0 && map[i, b - 1] != 0)
                map[i, b - 1] += 1;
            
            if (b != 9 && map[i, b + 1] != 0)
                map[i, b + 1] += 1;

            if (i != 9 && b != 0 && map[i + 1, b - 1] != 0)
                map[i + 1, b - 1] += 1;

            if (i != 9 && map[i + 1, b] != 0)
                map[i + 1, b] += 1;

            if (i != 9 && b != 9 && map[i + 1, b + 1] != 0)
                map[i + 1, b + 1] += 1;

            map[i, b] = 0;
        }
    }
}
