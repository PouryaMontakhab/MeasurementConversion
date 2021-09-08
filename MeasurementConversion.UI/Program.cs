using System;
using MeasurementConversion.Core.Measurements;
namespace MeasurementConversion.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            double mmetr, cmetr;

            var mtrToKm = new DistanceConverter("mm", "cm");
            mmetr = 16598;
            cmetr = mtrToKm.SourceToDestination(mmetr);
            Console.WriteLine("16598 meter in kilometer is : " + cmetr);
        }
    }
}
