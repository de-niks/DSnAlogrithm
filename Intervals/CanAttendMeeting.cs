using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervals

{
    internal class CanAttendMeetings
    {



        public class Interval
        {
            public int start, end;
            public Interval(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }

        public bool FindIfCanAttendMeetings(List<Interval> intervals)
        {

            bool canattendAllMeetings = true;

            intervals.Sort((i1, i2) => i1.start.CompareTo(i2.start));

            for (int i = 1; i < intervals.Count; i++)
            { 
               
                Interval I1 = intervals[i - 1];
                Interval I2 = intervals[i];

                if (I1.end > I2.start)
                {
                    canattendAllMeetings = false;
                    break;
                }
            
            }


            return canattendAllMeetings;
        
        }

        public static int can_attend_all_meetings(List<List<int>> intervals)
        {
            List<List<int>> sortedList = intervals.OrderBy(lst => lst[1]).ToList();

            for (int i = 1; i < intervals.Count; i++)
            {
                if (sortedList[i][1] > sortedList[i + 1][0])
                    return 0;
            }


            return 1;
        }

        public int MinMeetingRooms(List<Interval> intervals)
        {
            if(intervals.Count == 0)
                return 0;


            int[] start = new int[intervals.Count];
            int[] end = new int[intervals.Count];

            for (int i = 0; i < intervals.Count; i++)
            {
                start[i] = intervals[i].start;
                end[i] = intervals[i].end;
            }


            Array.Sort(start);
            Array.Sort(end);

            int result = 0;
            for (int lp = 0, rp = 0; lp < start.Length; lp++)
            {
                if (start[lp] < end[rp])
                    result++;
                else
                    rp++;
            }

            return result;
        }

    }
}
