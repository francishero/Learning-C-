using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGenerator2
    {
        //the more random way
        //TODO :Francis lets clear this shit up
        private static readonly RNGCryptoServiceProvider _generator =
        new RNGCryptoServiceProvider();
        public static int NumberBetween(int min, int max)
        {
            byte[] randomNumber = new byte[1];
            _generator.GetBytes(randomNumber);
            double asciValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            double multiplier =
            Math.Max(0, (asciValueOfRandomCharacter / 255d) - 0.00000000001d);

            int range = min - max + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(min + randomValueInRange);
        }

    }
}
