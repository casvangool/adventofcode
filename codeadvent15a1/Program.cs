using System;
using System.Collections.Generic;
using System.Linq;

namespace codeadvent15a1
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = Input.grid();
            var riskgrid = new int[grid.GetLength(0), grid.GetLength(1)];
            var positions = new List<(int x, int y, int risk)>();

            positions.Add((0, 0, 0));
            while(positions.Count > 0)
            {
                var position = positions.OrderBy(item => item.risk).First();

                if (position.x == grid.GetLength(0) - 1 && position.y == grid.GetLength(1))
                    break;

                positions.Remove(position);

                if (riskgrid[position.x, position.y] != 0)
                    continue;

                riskgrid[position.x, position.y] = position.risk;
                if(position.x > 0)
                {
                    positions.Add((position.x - 1, position.y, position.risk + grid[position.x - 1, position.y]));
                }
                if (position.y > 0)
                {
                    positions.Add((position.x, position.y - 1, position.risk + grid[position.x, position.y - 1]));
                }
                if(position.x < grid.GetLength(0) - 1)
                {
                    positions.Add((position.x + 1, position.y, position.risk + grid[position.x + 1, position.y]));
                }
                if (position.y < grid.GetLength(1) - 1)
                {
                    positions.Add((position.x, position.y + 1, position.risk + grid[position.x, position.y + 1]));
                }
            }
            Console.WriteLine(riskgrid[riskgrid.GetLength(0) - 1,riskgrid.GetLength(1) - 1]);
        }
    }
}
