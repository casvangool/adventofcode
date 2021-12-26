using System.Collections.Generic;

namespace codeadvent16b
{
    public static class Input
    {
        private static Dictionary<char, string> DecodeTable()
        {
            var dict = new Dictionary<char, string>();
            var data = @"0 = 0000
1 = 0001
2 = 0010
3 = 0011
4 = 0100
5 = 0101
6 = 0110
7 = 0111
8 = 1000
9 = 1001
A = 1010
B = 1011
C = 1100
D = 1101
E = 1110
F = 1111";
            var rows = data.Split("\r\n");
            for(int i = 0; i < rows.Length; i++)
            {
                dict.Add(rows[i].Split(" = ")[0][0], rows[i].Split(" = ")[1]);
            }
            return dict;
        }

        public static string DecodedMessage()
        {
            var dict = DecodeTable();
            string result = "";
            for (int i = 0; i < data.Length; i++)
            {
                result += dict[data[i]];
            }
            return result;
        }
        public static string data => @"C200B40A82";
    }
}
