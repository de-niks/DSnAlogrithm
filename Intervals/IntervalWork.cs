using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervals
{
    internal class IntervalWork
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="newInterval"></param>
        /// <returns></returns>
        public int[][] InsertInterval(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();

            for (int i = 0; i < intervals.Length; i++)
            {
                //End of new interval is less than start of ith intreval - non overlapping
                if (newInterval[1] < intervals[i][0])
                {
                    result.Add(newInterval);
                    result.AddRange(
                    intervals.AsEnumerable().Skip(i).ToArray());

                    return result.ToArray();
                }
                //Start of new interval is greater than end of ith interval - non overalapping
                else if (newInterval[0] > intervals[i][1])
                {
                    result.Add(intervals[i]);

                }
                else //overalapping
                {
                    newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                    newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                }
            }

            result.Add(newInterval);

            return result.ToArray();


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
            List<int[]> output = new List<int[]>();
            output.Add(intervals[0]);

            foreach (int[] interval in intervals)
            {
                int start = interval[0];
                int end = interval[1];
                int earlierEnd = output[output.Count - 1][1];

                if (start <= earlierEnd)
                {
                    output[output.Count - 1][1] = Math.Max(earlierEnd, end);

                }
                else
                {
                    output.Add(new int[] { start, end });
                }
            }

            return output.ToArray();

        }

        public int RemoveIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            int result = 0;

            int previousEnd = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            { 
                int newIntervalStart = intervals[i][0];
                int newIntervalEnd   = intervals[i][1];


                if (newIntervalStart >= previousEnd)
                {
                    previousEnd = newIntervalEnd;

                }
                else { 

                    result++;
                    previousEnd = Math.Min(previousEnd, newIntervalEnd);
                
                }
            }

            return result;

        }




    }
}
