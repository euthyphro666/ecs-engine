using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Aphelion.Maths
{

    /// <summary>
    /// Random Number Generator
    /// </summary>
    public class RNG
    {
        public static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        public byte[] random_number;

        public void Initialize_Module()
        {
            Cycle_RNG();
        }

        public void Cycle_RNG()
        {
            random_number = new byte[32];
            rngCsp.GetBytes(random_number);
        }

        /// <summary>
        /// Generates a number between a and b;
        /// </summary>
        public long Generate_RNG(int a, int b)
        {
            // If the bounds are equal there is only one number between them, return that
            if (a == b) return a;
            // Sort bounds by min and max
            var min = a <= b ? a : b;
            var max = a <= b ? b : a;

            // The only value that will cause out of range [min, max] is uint.MaxValue
            var gen = BitConverter.ToUInt32(random_number, 0);
            // So if it comes up re-gen value.
            while(gen == uint.MaxValue)
            {
                Cycle_RNG();
                gen = BitConverter.ToUInt32(random_number, 0);
            }

            // Get min/max range
            var range = (double)(max - min);
            // Get crypt rand number - Dist: [0, MAX)
            var rand = (double)gen;
            // Scale down to range - Dist: [0, (max - min) + 1)
            rand *= (range + 1.0) / uint.MaxValue;
            // Offset by min - Dist: [min, max + 1)
            rand += min;
            // Floor back to long and return it - Dist: [min, max]
            return (long)rand;
        }
    }
}

