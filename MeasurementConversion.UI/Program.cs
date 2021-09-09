using System;
using MeasurementConversion.Core.Measurements;
namespace MeasurementConversion.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fields
            string source, destination,next;
            double input;
            #endregion
            #region Existing Measurement
            var distanceConverter = new DistanceConverter();
            distanceConverter.DistanceConverterMeasurementList();
            do
            {
                distanceConverter.GetInputes(out input, out source, out destination);
                distanceConverter.Source = source;
                distanceConverter.Destination = destination;
                var result = distanceConverter.SourceToDestination(input);
                Console.WriteLine($"{input} {source} in {destination} is : " + result);
                Console.WriteLine("would you like to continue? y||n");
                next = Console.ReadLine();
            } while (next != "n");
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
