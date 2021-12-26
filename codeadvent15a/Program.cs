using System;

namespace codeadvent15a
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = Input.grid();
            var riskgrid = new int[grid.GetLength(0), grid.GetLength(1)];

            grid[0, 0] = 0;

            ProcesPosition(0, 0, grid, riskgrid);
            Console.WriteLine($"Risk: {riskgrid[riskgrid.GetLength(0) - 1, riskgrid.GetLength(1) - 1]}");
        }

        static void ProcesPosition(int x, int y, int[,] grid, int[,] riskgrid)
        {
            var valueposition = grid[x, y];
            if (x > 0 && y > 0 && riskgrid[x, y - 1] == 0 && riskgrid[x - 1, y] == 0)
            {
                return;
            }
            if (x > 0 && (riskgrid[x - 1, y] != 0 || (x == 1 && y == 0)))
            {
                var risk = riskgrid[x - 1, y] + grid[x, y];
                if (riskgrid[x, y] == 0 || riskgrid[x, y] > risk)
                {
                    riskgrid[x, y] = riskgrid[x - 1, y] + grid[x, y];
                }
            }
            if (y > 0 && (riskgrid[x, y - 1] != 0 || y == 1 && (x == 0 && y == 1)))
            {
                var risk = riskgrid[x, y - 1] + grid[x, y];
                if (riskgrid[x, y] == 0 || riskgrid[x, y] > risk)
                {
                    riskgrid[x, y] = riskgrid[x, y - 1] + grid[x, y];
                }
            }


            if (x < grid.GetLength(0) - 1)
            {
                ProcesPosition(x + 1, y, grid, riskgrid);
            }

            if (y < grid.GetLength(1) - 1)
            {
                ProcesPosition(x, y + 1, grid, riskgrid);
            }
        }
    }
}
