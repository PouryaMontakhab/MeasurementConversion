using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasurementConversion.Core.Basement
{
    public class MeasurementFactorSynonyms
    {
        #region Feilds
        public IEnumerable<string> Synonyms { get { return _synonyms.AsEnumerable(); } }
        List<string> _synonyms = new List<string>();
        #endregion
        #region Ctor
        public MeasurementFactorSynonyms() { }
        public MeasurementFactorSynonyms(params string[] items)
        {
            _synonyms.AddRange(items);
        }
        #endregion
        #region Methods
        internal bool Contains(MeasurementFactorSynonyms synonyms)
        {
            foreach (var item in synonyms.Synonyms)
            {
                if (this.Contains(item))
                    return true;
            }
            return false;
        }
        internal bool Contains(string item)
        {
            return _synonyms.Contains(item, StringComparer.CurrentCultureIgnoreCase);
        }
        public static implicit operator MeasurementFactorSynonyms(string synonym)
        {
            return new MeasurementFactorSynonyms(synonym);
        }
        public override int GetHashCode()
        {
            return _synonyms.GetHashCode();
        }
        public override string ToString()
        {
            return String.Join(", ", _synonyms);
        }
        #endregion

    }
}
