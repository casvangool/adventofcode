using System;

namespace codeadvent16b
{
    class Program
    {
        static int activepoint = 0;
        static int totalversion = 0;

        public static void ReadPackage()
        {
            var message = Input.DecodedMessage();
            totalversion += Convert.ToInt32(message.Substring(activepoint, 3), 2);
            activepoint += 3;
            var type = Convert.ToInt32(message.Substring(activepoint, 3), 2);
            activepoint += 3;
            if (type == 4)
            {
                // Literaal value
                bool lastvalue = false;
                string result = "";
                while (!lastvalue)
                {
                    var section = message.Substring(activepoint, 5);
                    lastvalue = section[0].Equals('0');
                    result += section.Substring(1, 4);
                    activepoint += 5;
                }
            }
            else
            {
                // operator
                bool fiveteenbitmode = message[activepoint].Equals('0');
                activepoint++; 
                if (fiveteenbitmode)
                {
                    var length = message.Substring(activepoint, 15);
                    activepoint += 15;

                    var amountofdigits = Convert.ToInt32(length, 2);
                    var stop = activepoint + amountofdigits;
                    while(activepoint < stop)
                    {
                        ReadPackage();
                    }
                }
                else
                {
                    var length = message.Substring(activepoint, 11);
                    activepoint += 11;
                    var amountofpackages = Convert.ToInt32(length, 2);
                    for (int i = 0; i < amountofpackages; i++)
                    {
                        ReadPackage();
                    }
                }
                
            }


        }
        static void Main(string[] args)
        {
            ReadPackage();
            Console.WriteLine(totalversion);
            
        }
    }
}
