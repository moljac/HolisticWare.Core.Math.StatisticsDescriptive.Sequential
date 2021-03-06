using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Kurtosis Sample Excess
    /// Excel KURT()
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see href="https://brownmath.com/stat/shape.htm"/>
    /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
   public static partial class IEnumerableExtensionsKurtosisSampleExcess
    {
        //==============================================================================================================
        public static double KurtosisSampleExcess
                                            (
                                                this Memory<byte> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<short> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<ushort> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<int> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<uint> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<long> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<ulong> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<float> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcess
                                            (
                                                this Memory<double> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static decimal KurtosisSampleExcess
                                            (
                                                this Memory<decimal> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }
        //==============================================================================================================

    }
}
