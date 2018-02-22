using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Linq_harjutus2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fail = ".../.../tekst.txt";
            string sisu = File.ReadAllText(fail);

            #region MituSõna
            sisu = sisu.ToLower();

            string[] eChar = {" ", ",", "\n", "\r" };

            int Sõnad = sisu.Split(eChar, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Sõnu on kokku: {0}", Sõnad);

            #endregion

            #region Erinevad tähed
            var TähtedeArv = sisu.Count(char.IsLetter); 






            #endregion

            #region Mitu korda esinevad

            #endregion

            #region Mitte korduv





            #endregion


            Console.ReadLine();
        }
    }
}
