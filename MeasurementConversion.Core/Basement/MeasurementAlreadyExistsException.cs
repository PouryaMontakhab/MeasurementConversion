using System;


namespace MeasurementConversion.Core.Basement
{
    public class MeasurementAlreadyExistsException : Exception
    {
        internal MeasurementAlreadyExistsException() { }
        internal MeasurementAlreadyExistsException(string unit) : base(String.Format("The given unit synonym '{0}' is already used in this converter", unit)) { }
    }
}
