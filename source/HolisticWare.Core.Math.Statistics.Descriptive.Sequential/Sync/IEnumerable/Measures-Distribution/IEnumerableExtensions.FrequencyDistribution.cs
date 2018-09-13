﻿using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsFrequencyDistibution
    {
        //==============================================================================================================
        public static 
            IEnumerable<KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> 
                FrequencyDistribution<T>
                                    (
                                        this IEnumerable<T> x
                                    )
        {
            Dictionary<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                    orderby pair.Key ascending
                                    select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            Dictionary<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            Dictionary<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            Dictionary<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            Dictionary<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            Dictionary<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            Dictionary<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            Dictionary<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }

        public static
            IEnumerable<KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            Dictionary<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            return frequencies_sorted;
        }
        //==============================================================================================================
    }
}
