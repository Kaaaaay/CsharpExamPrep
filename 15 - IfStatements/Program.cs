using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___IfStatements
{
    class Program
    {
        enum ClientType
        {
            Tingwenya = 1001,
            Lepara = 1002,
            General = 1003,
            Ladies = 1004

        }
        static void Main(string[] args)
        {
            //Enum ClientType = new Enum();
            ClientType ti = ClientType.Tingwenya;
            ClientType le = ClientType.Lepara;
            ClientType ge = ClientType.General;
            ClientType la = ClientType.Ladies;

            Console.WriteLine("Welcome to Ayepyep Lifestyle Cafe");
            Console.WriteLine();
            Console.Write("Please enter your client ID: \t");
            int clientID = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (clientID == 1001)
            {
                Console.WriteLine(ti + ",  please proceed to VVIP");
            }
            else if (clientID == 1002)
            {
                Console.WriteLine(le + ", please proceed to VIP");
            }
            else if (clientID == 1003)
            {
                Console.WriteLine(ge + " please proceed to the General Area");
            }
            else if (clientID == 1004)
            {
                Console.WriteLine(la + "  mantombazana, please wait to be placed. :)");
            }
            else
            {
                Console.WriteLine("Le nwele tse kae kgante? [Please enter your 4 digit Client ID]");

            }


            Console.ReadLine();
        }
    }
}
