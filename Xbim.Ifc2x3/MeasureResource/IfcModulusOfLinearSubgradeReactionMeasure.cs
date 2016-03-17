// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IfcModulusOfLinearSubgradeReactionMeasure", 614)]
	[DefinedType(typeof(double))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcModulusOfLinearSubgradeReactionMeasure : IfcDerivedMeasureValue, IExpressValueType, System.IEquatable<double>
	{ 
		private double _value;
        
		public object Value
        {
            get { return _value; }
        }

		public override string ToString()
        {
            return _value.ToString("R");
        }
        public IfcModulusOfLinearSubgradeReactionMeasure(double val)
        {
            _value = val;
        }

	    private static readonly System.Globalization.CultureInfo Culture =
	        System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

		public IfcModulusOfLinearSubgradeReactionMeasure(string val)
        {
			_value = System.Convert.ToDouble(val, Culture);
        }

        public static implicit operator IfcModulusOfLinearSubgradeReactionMeasure(double value)
        {
            return new IfcModulusOfLinearSubgradeReactionMeasure(value);
        }

        public static implicit operator double(IfcModulusOfLinearSubgradeReactionMeasure obj)
        {
            return obj._value;

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcModulusOfLinearSubgradeReactionMeasure) obj)._value == _value;
        }

		public bool Equals(double other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcModulusOfLinearSubgradeReactionMeasure obj1, IfcModulusOfLinearSubgradeReactionMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcModulusOfLinearSubgradeReactionMeasure obj1, IfcModulusOfLinearSubgradeReactionMeasure obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            _value = value.RealVal;
            
		}

		string IPersist.WhereRule()
		{
            throw new System.NotImplementedException();
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(double);
			}
		}
		#endregion


	}
}
