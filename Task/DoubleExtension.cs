using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
   
    /// <summary>
    /// Extension methods for Double
    /// </summary>
    public static class DoubleExtension
    {

        /// <summary>
        /// Convert double number in a binary code.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Binary code</returns>
        public static string ConvertDoubleToBinaryString(this double number)
        {
            DoubleToLongStruct numberInBinary = new DoubleToLongStruct(number);
            return ConvertToBinaryCode(numberInBinary.Long64Bits);
        }

        /// <summary>
        /// Convert long number in a binary system.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Number in binary system.</returns>
        private static string ConvertToBinaryCode(long number)
        {
            const int sizeOfBinaryCode = sizeof(long) * 8;

            char[] binaryCode = new char[sizeOfBinaryCode];
            for (int i = 0; i < sizeOfBinaryCode; i++)
            {
                // long to binary code
                binaryCode[i] = ((((long)1 << sizeOfBinaryCode - 1 - i) & number) != 0 ? '1' : '0');
            }
            return new string(binaryCode);
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct DoubleToLongStruct
        {
            [FieldOffset(0)]
            private readonly long long64bits;

            [FieldOffset(0)]
            private double double64bits;

            public DoubleToLongStruct(double number)
            {
                long64bits = 0;
                double64bits = number;
            }
            public long Long64Bits => long64bits;
        }
    }


    // First try
    // ><
    //
    //
    //public static class DoubleExtensionTest
    //{
    //    const int cMantissa = 52;
    //    const int cExponent = 11;
    //    /// <summary>
    //    ///                             DOUBLE
    //    ///  SIGN(1) EXPONENT(11)                     MANTISSA(52)
    //    ///    |0|  |00000000000| |0000000000000000000000000000000000000000000000000000|
    //    /// </summary>
    //    /// <param name="d"></param>
    //    /// <returns></returns>
    //    public static string ToBinaryCode(this double d)
    //    {
    //        const int signAndExpBits = 1 + cExponent;
    //        int exponent = 0;
    //        char[] binCode = new char[64];
    //        if (Math.Abs(d) < 1)
    //        {
    //            while (Math.Abs(d) < 1)
    //            {
    //                d *= 2;
    //                --exponent;
    //            }
    //        }
    //        else
    //        {
    //            while (Math.Abs(d) >= 2)
    //            {
    //                d /= 2;
    //                ++exponent;
    //            }
    //        }
    //        // sign
    //        binCode[0] = d < 0 ? '1' : '0';
    //        // epx
    //        exponent += 127;
    //        for (int i = 1; i < signAndExpBits; ++i)
    //        {
    //            if (exponent >= Math.Pow(2, cExponent - i))
    //            {
    //                binCode[i] = '1';
    //                exponent -= Convert.ToInt32(Math.Pow(2, cExponent - i));
    //            }
    //            else
    //            {
    //                binCode[i] = '0';
    //            }
    //        }
    //        // mnt
    //        --d;



    //        for (int i = signAndExpBits; i < signAndExpBits + cMantissa; ++i)
    //        {
    //            //
    //            if (d == 0)
    //            {
    //                for (; i < signAndExpBits + cMantissa - 1; ++i)
    //                {
    //                    binCode[i] = '0';
    //                }
    //            }

    //            d *= 2;
    //            if (d >= 1)
    //            {
    //                binCode[i] = '1';
    //                --d;
    //            }
    //            else
    //            {
    //                binCode[i] = '0';
    //            }


    //        }

    //        return new string(binCode);
    //    }
    //}

}