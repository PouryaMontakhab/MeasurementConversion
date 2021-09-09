using System;
using MeasurementConversion.Core.Measurements;
namespace MeasurementConversion.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fields
            double source, destination;
            #endregion
            #region Existing Measurement
            var mtrToKm = new DistanceConverter("mm", "yd");
            source = 16598;
            destination = mtrToKm.SourceToDestination(source);
            Console.WriteLine("16598 meter in kilometer is : " + destination);
            #endregion
            #region New Measurement
            //var distanceConverter = new DistanceConverter();
            //distanceConverter.AddMeasurement(new MeasurementFactorSynonyms("xm"), 100000);
            //distanceConverter.Source = "xm";
            //distanceConverter.Destination = "m";
            //source = 16000;
            //destination = distanceConverter.SourceToDestination(source);
            //Console.WriteLine("16000 xm in metere is : " + destination);
            #endregion
        }
    }
}
