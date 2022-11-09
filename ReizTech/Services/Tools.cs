using ReizTech.Models;
using System.Diagnostics.Metrics;

namespace ReizTech.Services
{
    public class Tools
    {
        public static int CalculateAngle(int hours, int minutes)
        {
            var hourAngle = 30 * hours;
            var minuteAngle = 6 * minutes;
            int angle;

            if (hourAngle > minuteAngle)
            {
               angle = hourAngle - minuteAngle;
            }
            else
            {
                angle = minuteAngle - hourAngle;
            }

            if (360-angle < angle)
            {
                angle = 360 - angle;
            }


            return angle;
        }

        public static int SearchDepth(Branch branch)
        {
            var acc = new List<int>();
            if (branch.Branches == null) return 1;

            
            foreach(var b in branch.Branches)
            {
                acc.Add(1 + SearchDepth(b));
            }


            return acc.Max();

        }
    }
}
