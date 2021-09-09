using MeasurementConversion.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeasurementConversion.Core.Basement
{
    public abstract class MeasurementConvertorService : IMeasurementConvertorService
    {
        #region Base
        protected void Instantiate(MeasurementFactors conversionMeasurement)
        {
            Measurements = conversionMeasurement;
            Source = Measurements.BasicMeasurement;
            Destination = Measurements.BasicMeasurement;
        }
        protected void Instantiate(MeasurementFactors conversionMeasurement,string source,string destination)
        {
            Measurements = conversionMeasurement;
            Source = source;
            Destination = destination;
        }
        #endregion
        #region Interface Service Implementation
        public double DestinationToSource(double input)
        {
            return XToY(input, Destination, Source);
        }

        public double SourceToDestination(double input)
        {
            return XToY(input, Source, Destination);
        }

        private double XToY(double input, string source, string destination)
        {
            var sourceFactor = Measurements.FindFactor(source);
            var destinationFactor = Measurements.FindFactor(destination);
            var result = (input / sourceFactor) * destinationFactor;
            return result.CheckCloseEnoughValue();
        }
        #endregion
        #region Methods
        public void AddMeasurement(MeasurementFactorSynonyms synonyms, double factor)
        {
            ValidateNewSynonym(synonyms);
            Measurements.Add(synonyms, factor);
        }
        #endregion
        #region Configuration
        private MeasurementFactors measurements;
        protected MeasurementFactors Measurements
        {
            get
            {
                if(measurements == null)
                    throw new NullReferenceException("Measurement Dictionary is not created");
                return measurements;
            }
            private set
            {
                measurements = value;
            }
        }
        private string source, destination;
        public string Source {
            get
            {
                if(string.IsNullOrEmpty(source))
                    throw new InvalidOperationException("Soure has not been set");
                return source;
            }
            set
            {
                ValidateSynonymExists(value);
                source = value;
            }
        }
        public string Destination
        {
            get
            {
                if (string.IsNullOrEmpty(destination))
                    throw new InvalidOperationException("Destination has not been set");
                return destination;
            }
            set
            {
                ValidateSynonymExists(value);
                destination = value;
            }
        }
        #endregion
        #region Validation
        private void ValidateSynonymExists(string synonym)
        {
            if (null == Measurements.FindMeasurement(synonym))
            {   
                throw new MeasurementNotSupportedException(synonym);
            }
        }
        private void ValidateNewSynonym(MeasurementFactorSynonyms synonyms)
        {
            var preExistingUnit = Measurements.FindMeasurement(synonyms);
            if (preExistingUnit != null)
            {
                throw new MeasurementAlreadyExistsException(preExistingUnit.ToString());
            }
        }
        #endregion
    }
}
