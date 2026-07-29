using DiGi.Core.Classes;

namespace DiGi.Communication.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.RangeResult"/> for the propagation calculation result from the specified angular bin.
        /// <para>The bounds are copied in radians, as everything else in the propagation calculation result.</para>
        /// </summary>
        /// <param name="range">The angular bin. This value can be null.</param>
        /// <returns>A <see cref="Classes.RangeResult"/> holding the bounds of the bin, or null if the bin is null.</returns>
        public static Classes.RangeResult? RangeResult(this Range<double>? range)
        {
            if (range is null)
            {
                return null;
            }

            return new(range.Min, range.Max);
        }

        /// <summary>
        /// Creates the <see cref="Classes.RangeResult"/> instances for the propagation calculation result from the specified angular bins, skipping the ones that could not be converted.
        /// </summary>
        /// <param name="ranges">The angular bins. This value can be null.</param>
        /// <returns>The <see cref="Classes.RangeResult"/> instances holding the bounds of the bins. The list is empty rather than null when there is nothing to convert.</returns>
        public static List<Classes.RangeResult> RangeResults(this IEnumerable<Range<double>>? ranges)
        {
            List<Classes.RangeResult> rangeResults = [];
            if (ranges is null)
            {
                return rangeResults;
            }

            foreach (Range<double> range in ranges)
            {
                if (range.RangeResult() is Classes.RangeResult rangeResult)
                {
                    rangeResults.Add(rangeResult);
                }
            }

            return rangeResults;
        }
    }
}
