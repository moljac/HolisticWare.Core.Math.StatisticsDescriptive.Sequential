using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// KurtosisType2
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
    public static partial class IEnumerableExtensionsKurtosisType2
    {
        //==============================================================================================================
        /// <summary>
        /// KurtosisType2
        /// Sharpness of the peak of a frequency-distribution curve.
        /// Kurtosis of the Type2 (unbiased under normality)
        /// 
        /// used in SPSS and SAS (consistent with classical use of kurtosis in political science analyses)
        /// </summary>
        /// <returns>Kurtosis of type2.</returns>
        /// <param name="x">x data</param>
        /// <see href="https://www.rdocumentation.org/packages/SciencesPo/versions/1.4.1/topics/Kurtosis"/>
        /// <see href="https://docs.scipy.org/doc/scipy-0.7.x/reference/generated/scipy.stats.kurtosis.html"/>
        public static double KurtosisType2
                                    (
                                        this Memory<byte> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<short> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<ushort> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<int> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<uint> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<long> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<ulong> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<float> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static double KurtosisType2
                                    (
                                        this Memory<double> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0) * g_2 + 6.0) * (n - 1.0) / (n - 2.0) * (n - 3.0);
        }

        public static decimal KurtosisType2
                                    (
                                        this Memory<decimal> x
                                    )
        {
            decimal g_2 = x.KurtosisType1();
            int n = x.Count();

            return ((n + 1.0m) * g_2 + 6.0m) * (n - 1.0m) / (n - 2.0m) * (n - 3.0m);
        }
        //==============================================================================================================
    }
}
