﻿using System;

namespace codeadvent15a
{
    public static class Input
    {
        public static int[,] grid()
        {
            string[] rows = data.Split("\r\n");
            int[,] grid = new int[rows[0].Length, rows.Length];
            for(int i = 0; i < rows.Length; i++)
            {
                for(int b = 0; b < rows[i].Length; b++)
                {
                    grid[b, i] = Convert.ToInt32(rows[i][b].ToString());
                }
            }
            return grid;
        } 

        public static string data => @"1947696975698896797929459993778378493663187915544561834986191836269969899167858897819699793994718987
2311559817927999719999597987189844226139358211239975663924921992997751999137989799783998666847189117
1398783175891937833687888598786896125883638881619291974159998891739786137969443961276399292284679298
1799975998227669996115794797677699798175616958417287499395295199789322764647852198997299659859389619
1739612118291539157254493162397155936981318995862379954635661973979239239969788818966686499766387398
8719671599693942744933141579913498448999942189769767769727796927818765883586697625896957338688939595
";
    }
}
