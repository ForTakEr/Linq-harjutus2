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

            Console.WriteLine("Erinevaid tähti on: {0}", TähtedeArv);
            #endregion

            #region Mitu korda esinevad
            var Esinemine = sisu.ToLower().GroupBy(x => x).Select(x => new { Char = x.Key, Count = x.Count(char.IsLetter) }).OrderByDescending(x => x.Count);

            var Loend = (from täht in Esinemine
                         where täht.Count > 0
                         select täht).ToList();

            foreach (var item in Loend)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Mitte korduv
            var Words = new List<string> { };

            var sõnad = sisu.Split(eChar, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in sõnad)
            {
                if (!Words.Contains(item))
                {
                    Words.Add(item);
                }
            }
            Console.WriteLine("Tekst ilma sõnade kordumiseta: ");
            foreach (var item in Words)
            {
                Console.WriteLine(item + " ");
            }


            #endregion


            Console.ReadLine();
        }
    }
}
