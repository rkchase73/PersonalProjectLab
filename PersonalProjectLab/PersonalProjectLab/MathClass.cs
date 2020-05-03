using System;
namespace PersonalProjectLab
{
    public class MathClass
    {
        public int CurrentMiles;

        public MathClass()
        {
            
        }

        public int CalculateTotalMiles(int MilesRan)
        {
            int TotalMiles = 0;
            TotalMiles = MilesRan + CurrentMiles;
            return TotalMiles;
        }

        public decimal CalculateAverageTime(decimal run, decimal timeHours, decimal timeMinutes)
        {
            
            decimal Average = 0;
            Average =((timeHours * 60) + timeMinutes) / run;
            return Average;
        }
    }
}
