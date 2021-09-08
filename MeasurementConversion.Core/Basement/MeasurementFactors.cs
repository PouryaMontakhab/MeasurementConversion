using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasurementConversion.Core.Basement
{
    public class MeasurementFactors : Dictionary<MeasurementFactorSynonyms, double>
    {
        #region Fields
        private string _basicMeasurement;
        public string BasicMeasurement
        {
            get
            {
                return _basicMeasurement;
            }
            set
            {
                this._basicMeasurement = value;
            }
        }
        #endregion
        #region Ctor
        public MeasurementFactors(string basicMeasurement)
        {
            _basicMeasurement = basicMeasurement;
        }
        #endregion
        #region Methods
        internal MeasurementFactorSynonyms FindMeasurement(MeasurementFactorSynonyms synonyms)
        {
            return this.Keys.FirstOrDefault(f => f.Contains(synonyms));
        }
        internal double FindFactor(MeasurementFactorSynonyms synonyms)
        {
            var unit = this.FirstOrDefault(factor => factor.Key.Contains(synonyms));
            if (unit.Key == null)
            {
                throw new MeasurementNotSupportedException(synonyms.ToString());
            }
            return unit.Value;
        }
        #endregion
    }
}
