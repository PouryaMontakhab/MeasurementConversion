using System;
using System.Collections.Generic;
using System.Text;

namespace MeasurementConversion.Core.Interface
{
    internal interface IMeasurementConvertorService
    {
        double SourceToDestination(double input);
        double DestinationToSource(double input);
    }
}
