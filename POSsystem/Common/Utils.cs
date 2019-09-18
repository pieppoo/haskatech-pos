using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POSsystem.Common
{
    public static class Utils
    {
        private static CultureInfo _indonesiaCultureInfo;

        public static CultureInfo IndonesiaCultureInfo
        {
            get
            {
                if(_indonesiaCultureInfo == null)
                {
                    _indonesiaCultureInfo = CultureInfo.CreateSpecificCulture("id-id");
                    _indonesiaCultureInfo.NumberFormat.NumberDecimalDigits = 0;
                }
               
                return _indonesiaCultureInfo;
            }
        }
        
        /**
         * // Usage example: //
         * int angka = 10000000;
         * System.Console.WriteLine(angka.ToRupiah()); // -> Rp. 10.000.000
         */
        public static string ToRupiahWithSymbol(int angka)
        {
            return String.Format(IndonesiaCultureInfo, "Rp. {0:N}", angka);
        }
        
        public static string ToRupiah(int angka)
        {
            return String.Format(IndonesiaCultureInfo, "{0:N}", angka);
        }

        public static string ToRupiah(double angka)
        {
            return String.Format(IndonesiaCultureInfo, "{0:N}", angka);
        }

        /**
         * // Usage example: //
         * string rupiah = "Rp 10.000.123,00";
         * System.Console.WriteLine(rupiah.ToAngka()); // -> 10000123
         */
        public static int ToNumbers(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }
    }
}
