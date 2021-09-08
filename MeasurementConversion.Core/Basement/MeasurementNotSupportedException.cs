using System;

namespace MeasurementConversion.Core.Basement
{
    public class MeasurementNotSupportedException : NotSupportedException
    {
        internal MeasurementNotSupportedException() { }
        internal MeasurementNotSupportedException(string unit) : base(String.Format("The Measurement '{0}' is not supported by this converter", unit)) { }
    }
}
