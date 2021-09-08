using MeasurementConversion.Core.Basement;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeasurementConversion.Core.Measurements
{
    public class DistanceConverter : MeasurementConvertorService
    {
        #region Instantiation
        MeasurementFactors measurements = new MeasurementFactors("m")
        {
            { new MeasurementFactorSynonyms("m", "metre"), 1 },
            { new MeasurementFactorSynonyms("km", "kilometre"), 0.001 },
            { new MeasurementFactorSynonyms("cm", "centimetre"), 100 },
            { new MeasurementFactorSynonyms("mm", "millimetre"), 1000 },
            { new MeasurementFactorSynonyms("ft", "foot", "feet"), 1250d / 381 },
            { new MeasurementFactorSynonyms("yd", "yard"), 1250d / 1143 },
            { "mile", 125d / 201168 },
            { new MeasurementFactorSynonyms("in", "inch"), 5000d / 127 },
            { "au", 1d / 149600000000}
        };
        public DistanceConverter(string source, string destination)
        {
            Instantiate(measurements, source, destination);
        }
        public DistanceConverter()
        {
            Instantiate(measurements);
        }
        #endregion       
    }
}
